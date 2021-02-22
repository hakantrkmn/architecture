using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gecilebilirCube : MonoBehaviour
{
    public Material tugla;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("gameManager").GetComponent<gameManager>().hit == 3)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().material = tugla;
        }
    }


}
