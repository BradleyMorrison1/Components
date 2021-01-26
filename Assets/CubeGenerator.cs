using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    void Start()
    {
        // Transform Component
        //float scale = 1.0f;
        //gameObject.transform.position = new Vector3(0, 3, 0); // implicit type casting/conversion (from int to float)
        //gameObject.transform.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);
        //gameObject.transform.localScale = Vector3.one * scale;

        // Mesh Renderer Component
        //gameObject.GetComponent<MeshRenderer>().enabled = false;

        // RigidBody Component
        //gameObject.AddComponent<Rigidbody>();


        GameObject[] cubes; // Proper Way

    }

    void Update()
    {
        // Transform Component
        //gameObject.transform.Translate(new Vector3(0.0f, 0.0f, 0.0f));
        
        GameObject cube; // Individually (and lose the reference after)
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.AddComponent<Rigidbody>();

        // change color
        Color[] colors = { Color.cyan, Color.magenta, };
        cube.GetComponent<MeshRenderer>().material.SetColor("_Color", colors[Random.Range(0, 2)]);

    }
}
