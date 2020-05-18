using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public GameObject Cube;
    Vector3 rotAngle = new Vector3(0.5f, 1.0f, 1.0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube.transform.Rotate(rotAngle);
    }
}
