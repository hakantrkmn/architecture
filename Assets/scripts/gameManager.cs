using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gameManager : MonoBehaviour
{
    public int sceneIndex;
    public int cubeCount;
    public int hit;
    public GameObject cubes;
    public opaqueMove opaqueCube;
    public TextMeshProUGUI saniye;
    public bool saniyeDur;
    float sayac;
    public GameObject gameOverMenu;
    bool ittir;
    public GameObject secondCamera;
    public GameObject doneButton;
    public GameObject retryButton;
    public GameObject saniyeText;
    // Start is called before the first frame update

    private void Awake()
    {
        if (PlayerPrefs.HasKey("firstOpen"))
        {
            if (PlayerPrefs.GetInt("firstOpen") == 1)
            {
                doneButton.SetActive(false);
                retryButton.SetActive(false);
                saniyeText.SetActive(false);
            }
            else
            {
                Destroy(GameObject.Find("start"));
            }
        }
    }
    void Start()
    {
        PlayerPrefs.SetInt("level_" + SceneManager.GetActiveScene().buildIndex , 1);
        hit = 0;
        saniyeDur = false;
        sayac = 60;
        saniye.text = "Level " +SceneManager.GetActiveScene().buildIndex.ToString();
        cubeCount = 0;
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameObject.Find("start"))
            {
                Destroy(GameObject.Find("start"));
                doneButton.SetActive(true);
                retryButton.SetActive(true);
                saniyeText.SetActive(true);
                //secondCamera.SetActive(true);
                PlayerPrefs.SetInt("firstOpen", 0);

            }
        }
        Debug.LogError(hit);
        if (saniyeDur==true)
        {
            sayac = 0;
        }
        if (hit>0)
        {
            Camera.main.GetComponent<cameraMove>().turn = 1;
            StartCoroutine(isGameOver());
        }
        else if (hit==-1 )
        {
            StartCoroutine(reloadScene());
        }
        if (SceneManager.GetActiveScene().buildIndex!=0)
        {
            if (sayac <= 0)
            {
                waitForBuild();
                
            }

        }
    }





    IEnumerator isGameOver()
    {
        yield return new WaitForSeconds(1f);
        if (hit == 3)
        {
            gameOverMenu.SetActive(true);
            PlayerPrefs.SetInt("level_" + (SceneManager.GetActiveScene().buildIndex +1), 1);
        }
        else if ( hit == 1 || hit == 0 || hit == 2|| hit > 3)
        {
            StartCoroutine(reloadScene());
        }
    }

    IEnumerator reloadScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void waitForBuild()
    {

        opaqueCube.isCubesMoving = true;

        if (hit==-1 || hit >2)
        {

        }
        else
        {
            Camera.main.GetComponent<cameraMove>().turn = 0;
            cubes.transform.position = new Vector3(cubes.transform.position.x - 0.03f, cubes.transform.position.y, cubes.transform.position.z);
            cubes.transform.position = new Vector3(cubes.transform.position.x - 0.03f, cubes.transform.position.y, cubes.transform.position.z);

        }




    }

    public void nextLevel()
    {
        StartCoroutine(startLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator startLevel(int index)
    {
        GameObject.Find("fade").GetComponent<Animator>().SetBool("gameOver", true);
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(index);

    }
    public void loadMenu()
    {
        StartCoroutine(startLevel(1));
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
