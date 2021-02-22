using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgCube : MonoBehaviour
{
    public int xMove;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (xMove==1)
        {

            transform.localPosition-= new Vector3(0.003f, 0, 0);

        }
        else
        {
            transform.position += new Vector3(0, 0, 0.003f);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="enemy")
        {
            var temp = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
