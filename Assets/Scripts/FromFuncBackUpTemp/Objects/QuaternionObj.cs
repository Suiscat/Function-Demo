using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionObj : MonoBehaviour
{
    Vector3 fd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation *= Quaternion.AngleAxis(15, Vector3.up);
            print("当前四元数" + transform.rotation);

            fd = Quaternion.AngleAxis(45, Vector3.up) * transform.forward;
            
            print("当前fd朝向向量:" + fd);
            print("向量朝向转四元数：" + Quaternion.LookRotation(fd));
        }
        // Debug.DrawLine(transform.position, transform.forward * 5 + transform.position, Color.green);
    }
}
