using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opaqueMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject currentCube;
    public GameObject cube;
    public static GameObject cCube;
    public GameObject ground;
    public GameObject parent;
    public int level;
    public GameObject top;
    public float time;
    public gameManager cubeCount;
    public float force;

    public bool isCubesMoving;
    public Vector3 offset;
    public float second = 0.7f;

    public GameObject newBoxParticle;
    void Start()
    {
        second = 0.7f;
        isCubesMoving = false;
        cCube = GameObject.Find("yCube");
        level = 1;
        change();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (isCubesMoving == true)
            {
                Destroy(gameObject);
            }
            if (Input.GetMouseButtonDown(0) && UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() == false)
            {
                    var newcube = Instantiate(cube, transform.position, Quaternion.identity);

                gameObject.GetComponent<AudioSource>().Play();
                    newcube.transform.parent = parent.transform;
                var temp = Instantiate(newBoxParticle, (newcube.transform.position + currentCube.transform.position) / 2, Quaternion.identity);
                Destroy(temp, 2f);
                offset = Camera.main.transform.position - currentCube.transform.position;
                    Camera.main.transform.position = newcube.transform.position + offset;
                    
                    cubeCount.cubeCount += 1;
                    cCube = newcube;
                    currentCube = newcube;
                    level += 1;


                




            }
        }
        

    }



    void change()
    {
        StartCoroutine(changePosition());

    }


    IEnumerator changePosition()
    {

            if (!Physics.CheckBox(new Vector3(currentCube.transform.position.x + 1, currentCube.transform.position.y, currentCube.transform.position.z), Vector3.one / 4, Quaternion.identity))
            {
                transform.position = new Vector3(currentCube.transform.position.x + 1, currentCube.transform.position.y, currentCube.transform.position.z);
                yield return new WaitForSeconds(second);
            }
            if (!Physics.CheckBox(new Vector3(currentCube.transform.position.x - 1, currentCube.transform.position.y, currentCube.transform.position.z), Vector3.one / 4, Quaternion.identity))
            {
                transform.position = new Vector3(currentCube.transform.position.x - 1, currentCube.transform.position.y, currentCube.transform.position.z);
                yield return new WaitForSeconds(second);
            }
            if (!Physics.CheckBox(new Vector3(currentCube.transform.position.x, currentCube.transform.position.y, currentCube.transform.position.z + 1), Vector3.one / 4, Quaternion.identity))
            {

                transform.position = new Vector3(currentCube.transform.position.x, currentCube.transform.position.y, currentCube.transform.position.z + 1);
                yield return new WaitForSeconds(second);
            }
            if (!Physics.CheckBox(new Vector3(currentCube.transform.position.x, currentCube.transform.position.y, currentCube.transform.position.z - 1), Vector3.one / 4, Quaternion.identity))
            {
                transform.position = new Vector3(currentCube.transform.position.x, currentCube.transform.position.y, currentCube.transform.position.z - 1);
                yield return new WaitForSeconds(second);
            }
            if (!Physics.CheckBox(new Vector3(currentCube.transform.position.x, currentCube.transform.position.y + 1, currentCube.transform.position.z), Vector3.one / 4, Quaternion.identity))
            {
                transform.position = new Vector3(currentCube.transform.position.x, currentCube.transform.position.y + 1, currentCube.transform.position.z);
                yield return new WaitForSeconds(second);
            }
            if (!Physics.CheckBox(new Vector3(currentCube.transform.position.x, currentCube.transform.position.y - 1, currentCube.transform.position.z), Vector3.one / 4, Quaternion.identity))
            {
                transform.position = new Vector3(currentCube.transform.position.x, currentCube.transform.position.y - 1, currentCube.transform.position.z);
                yield return new WaitForSeconds(second);
            }
            change();

        



    }
}
