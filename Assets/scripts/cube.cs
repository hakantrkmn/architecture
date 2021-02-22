using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("sadassadas");

        if (collision.transform.tag=="enemy")
        {
            GetComponent<AudioSource>().Play();
            GameObject.Find("gameManager").GetComponent<gameManager>().hit = -1;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<ParticleSystem>().Play();
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "gameOver")
        {
            GameObject.Find("gameManager").GetComponent<gameManager>().hit += 1;

        }
    }


}
