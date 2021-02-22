using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnAround : MonoBehaviour
{
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(plane.transform.position, Vector3.up, 10 * Time.deltaTime);

    }
}
