using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDownAnim : MonoBehaviour
{
    Vector3 position;
    bool moveUp;
    bool moveDown;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        moveUp = true ;
        moveDown = false;
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);
        Debug.Log(position.y -5);
        
        if (transform.position.y > position.y + distance)
        {
            moveDown = true;
            moveUp = false;
        }
        else if (transform.position.y < position.y - distance)
        {
            moveDown = false;
            moveUp = true;
        }
        if (moveUp== true)
        {
            transform.position = transform.position + new Vector3(0, +0.01f, 0);

        }
        else if (moveDown==true)
        {
            transform.position = transform.position + new Vector3(0, -0.01f, 0);
        }

    }
}
