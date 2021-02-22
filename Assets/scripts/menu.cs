using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject secondCamera;
    public GameObject levelPanel;
    public GameObject continueBut;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("level_2"))
        {
            if (SceneManager.GetActiveScene().buildIndex==0)
            {
                continueBut.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        StartCoroutine(startLevel(1));
    }
    public void levels()
    {
        levelPanel.SetActive(true);
    }   
    public void back()
    {
        levelPanel.SetActive(false);
    }

    public void saniyeDurdur()
    {

        GameObject.Find("gameManager").GetComponent<gameManager>().saniyeDur = true;
    }

    public void continueButton()
    {
        for (int i = 16; i > 0; i--)
        {
            if (PlayerPrefs.HasKey("level_"+ i))
            {
                if (PlayerPrefs.GetInt("level_"+i)==1)
                {
                    StartCoroutine(startLevel(i));
                    return;
                }
            }
        }
    }




    IEnumerator startLevel(int index)
    {
        GameObject.Find("fade").GetComponent<Animator>().SetBool("gameOver", true);
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(index);

    }




    public void level_1()
    {
        if (PlayerPrefs.HasKey("level_1"))
        {
            if (PlayerPrefs.GetInt("level_1")==1)
            {
                StartCoroutine(startLevel(1));

            }
        }
    }
    public void level_2()
    {
        if (PlayerPrefs.HasKey("level_2"))
        {
            if (PlayerPrefs.GetInt("level_2") == 1)
            {
                StartCoroutine(startLevel(2));

            }
        }
    }
    public void level_3()
    {
        if (PlayerPrefs.HasKey("level_3"))
        {
            if (PlayerPrefs.GetInt("level_3") == 1)
            {
                StartCoroutine(startLevel(3));

            }
        }
    }
    public void level_4()
    {
        if (PlayerPrefs.HasKey("level_4"))
        {
            if (PlayerPrefs.GetInt("level_4") == 1)
            {
                StartCoroutine(startLevel(4));

            }
        }
    }
    public void level_5()
    {
        if (PlayerPrefs.HasKey("level_5"))
        {
            if (PlayerPrefs.GetInt("level_5") == 1)
            {
                StartCoroutine(startLevel(5));

            }
        }
    }
    public void level_6()
    {
        if (PlayerPrefs.HasKey("level_6"))
        {
            if (PlayerPrefs.GetInt("level_6") == 1)
            {
                StartCoroutine(startLevel(6));

            }
        }
    }
    public void level_7()
    {
        if (PlayerPrefs.HasKey("level_7"))
        {
            if (PlayerPrefs.GetInt("level_7") == 1)
            {
                StartCoroutine(startLevel(7));

            }
        }
    }
    public void level_8()
    {
        if (PlayerPrefs.HasKey("level_8"))
        {
            if (PlayerPrefs.GetInt("level_8") == 1)
            {
                StartCoroutine(startLevel(8));

            }
        }
    }
    public void level_9()
    {
        if (PlayerPrefs.HasKey("level_9"))
        {
            if (PlayerPrefs.GetInt("level_9") == 1)
            {
                StartCoroutine(startLevel(9));

            }
        }
    }
    public void level_10()
    {
        if (PlayerPrefs.HasKey("level_10"))
        {
            if (PlayerPrefs.GetInt("level_10") == 1)
            {
                StartCoroutine(startLevel(10));

            }
        }
    }
    public void level_11()
    {
        if (PlayerPrefs.HasKey("level_11"))
        {
            if (PlayerPrefs.GetInt("level_11") == 1)
            {
                StartCoroutine(startLevel(11));

            }
        }
    }
    public void level_12()
    {
        if (PlayerPrefs.HasKey("level_12"))
        {
            if (PlayerPrefs.GetInt("level_12") == 1)
            {
                StartCoroutine(startLevel(12));

            }
        }
    }
    public void level_13()
    {
        if (PlayerPrefs.HasKey("level_13"))
        {
            if (PlayerPrefs.GetInt("level_13") == 1)
            {
                StartCoroutine(startLevel(13));

            }
        }
    }
    public void level_14()
    {
        if (PlayerPrefs.HasKey("level_14"))
        {
            if (PlayerPrefs.GetInt("level_14") == 1)
            {
                StartCoroutine(startLevel(14));

            }
        }
    }
    public void level_15()
    {
        if (PlayerPrefs.HasKey("level_15"))
        {
            if (PlayerPrefs.GetInt("level_15") == 1)
            {
                StartCoroutine(startLevel(15));

            }
        }
    }
    public void level_16()
    {
        if (PlayerPrefs.HasKey("level_16"))
        {
            if (PlayerPrefs.GetInt("level_16") == 1)
            {
                StartCoroutine(startLevel(16));

            }
        }
    }
    public void level_17()
    {
        if (PlayerPrefs.HasKey("level_17"))
        {
            if (PlayerPrefs.GetInt("level_17") == 1)
            {
                StartCoroutine(startLevel(17));

            }
        }
    }






}
