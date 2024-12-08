using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    public float rotateRate = 30f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.forward * 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * rotateRate * Time.deltaTime);
    }
}
