using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCreate : MonoBehaviour
{
    public GameObject createObj;
    public float hitDistance = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),
                out hit,
                hitDistance,
                1 << LayerMask.NameToLayer("HitAble")
                ))
            {
                print("点击到可点击物体");
                GameObject obj = GameObject.Instantiate(createObj);
                obj.transform.position = hit.point;
            }
        }
    }
}
