using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(GameObject.Find("zemin").transform.position.x - 15, transform.position.y - 0.05f, GameObject.Find("zemin").transform.position.z - 5);
    }
}
