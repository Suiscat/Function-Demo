using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoubleClick : MonoBehaviour
{
    public float intervalTime = 0.5f;

    private bool isFirst = true;
    // 记录与上次的时间间隔
    private float nowTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFirst)
        {
            nowTime += Time.deltaTime;
            // 这里判断的 逻辑与下面判断不同
            // 好好思考，0.5s自动给你断开
            if (nowTime > intervalTime)
            {
                isFirst = true;
                nowTime = 0;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (isFirst)
            {
                isFirst = false;
                nowTime = 0;
            }
            else
            {
                //if (nowTime > intervalTime)
                //{
                //    print("超出限定时间：" + nowTime);
                //}
                //// 属于双击范围内 操作
                //else
                {
                    print("规定时间范围内：" + nowTime + "创建物体");
                    // 在鼠标点击位置，创建cube
                    GameObject obj = Instantiate(Resources.Load<GameObject>("Cube"));
                    RaycastHit hit;
                    Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),
                        out hit,
                        1000,
                        1 << LayerMask.NameToLayer("Platform")
                        );
                    obj.transform.position = hit.point;
                }
                nowTime = 0;
                isFirst = true;
            }
            
        }
    }
    public void TestOut(out int value)
    {
        value = 0;
        print("test");
    }
}
