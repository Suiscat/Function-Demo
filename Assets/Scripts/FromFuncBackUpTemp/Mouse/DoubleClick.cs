using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoubleClick : MonoBehaviour
{
    public float intervalTime = 0.5f;

    private bool isFirst = true;
    // ��¼���ϴε�ʱ����
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
            // �����жϵ� �߼��������жϲ�ͬ
            // �ú�˼����0.5s�Զ�����Ͽ�
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
                //    print("�����޶�ʱ�䣺" + nowTime);
                //}
                //// ����˫����Χ�� ����
                //else
                {
                    print("�涨ʱ�䷶Χ�ڣ�" + nowTime + "��������");
                    // �������λ�ã�����cube
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
