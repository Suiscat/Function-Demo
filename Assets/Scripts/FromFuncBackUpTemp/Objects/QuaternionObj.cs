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
            print("��ǰ��Ԫ��" + transform.rotation);

            fd = Quaternion.AngleAxis(45, Vector3.up) * transform.forward;
            
            print("��ǰfd��������:" + fd);
            print("��������ת��Ԫ����" + Quaternion.LookRotation(fd));
        }
        // Debug.DrawLine(transform.position, transform.forward * 5 + transform.position, Color.green);
    }
}
