using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMove : MonoBehaviour
{
    private GameObject nowSelObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),
                out hitInfo,
                1000,
                1 << LayerMask.NameToLayer("Player")))
            {
                nowSelObj = hitInfo.collider.gameObject;
            }
        }

        if (Input.GetMouseButton(0) && nowSelObj != null)
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),
                out hitInfo,
                1000,
                1 << LayerMask.NameToLayer("Platform")))
            {
                nowSelObj.transform.position = hitInfo.point + Vector3.up * 1f;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            nowSelObj = null;
        }
    }
}
