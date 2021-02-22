using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverBox : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("gameManager").GetComponent<gameManager>().hit == 2)
        {
            GetComponent<BoxCollider>().enabled = true;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
    }
}
