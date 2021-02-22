using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraMove : MonoBehaviour
{
    public int turn;
    public Vector3 offset;
    public GameObject currentCube;
    public Vector3 aci ;
    public GameObject plane;
    public GameObject dNoktasi;
    Transform firstTransform;


    // Start is called before the first frame update
    void Start()
    {

        firstTransform = transform;
        turn = 2;
        aci = new Vector3(0, 6.3f, 3);
        offset = transform.position - currentCube.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        currentCube = opaqueMove.cCube;

        if (SceneManager.GetActiveScene().buildIndex==0)
        {
            transform.RotateAround(currentCube.transform.position, Vector3.up, 8 * Time.deltaTime);
        }
        else
        {
            if (turn == 1)
            {
                transform.RotateAround(dNoktasi.transform.position, Vector3.up, 5 * Time.deltaTime);
            }
            else if(turn==0)
            {

                transform.eulerAngles = new Vector3(transform.eulerAngles.x, -108, transform.eulerAngles.z);
                transform.position = currentCube.transform.parent.position + offset;
                transform.position = new Vector3(transform.position.x, transform.position.y, 8);

            }
        }
        


        //if (opaqueMove.cCube != currentCube)
        //{

        //    //transform.position = Vector3.Lerp(transform.position, currentCube.transform.position + offset, 5);
        //}

    }
}
