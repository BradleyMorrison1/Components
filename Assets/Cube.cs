using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    void Start()
    {
        //Vector3 position;
        //position.x = 0.0f;
        //position.y = 2.0f;
        //position.z = 0.0f;
        //gameObject.transform.position = position;

        //gameObject.transform.position = new Vector3(0, 2, 0); // implicit type casting/conversion (from int to float)

        gameObject.transform.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);

    }

    void Update()
    {
        
    }
}
