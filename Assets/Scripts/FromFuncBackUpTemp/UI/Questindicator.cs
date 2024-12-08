using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questindicator : MonoBehaviour
{
    public Image arrowImg;
    public Transform target;
    Camera mainCamera => Camera.main;
    RectTransform indicator => arrowImg.rectTransform; 
    static Rect rect = new Rect(0, 0, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null || mainCamera == null) return;
        // 获得目标的视口坐标系
        Vector3 targetViewportPos = mainCamera.WorldToViewportPoint(target.position);

        // 判断是否在视野内
        if (targetViewportPos.z > 0 && rect.Contains(targetViewportPos))
        {
            // 这里-0.5是因为，锚点设置在中心，所以要根据锚点设置相对位置做偏移
            // indicator.anchoredPosition = new Vector2((targetViewportPos.x - 0.5f) * Screen.width,
                                                    // (targetViewportPos.y - 0.5f) * Screen.height);
            // 这里把锚点设置在左下角就OK
            indicator.anchoredPosition = new Vector2((targetViewportPos.x) * Screen.width,
                                                    (targetViewportPos.y) * Screen.height);
            indicator.rotation = Quaternion.identity;
        }
        else
        {
            Vector3 screenCenter = new Vector3(Screen.width, Screen.height, 0) / 2;
            Vector3 targetScreenPos = mainCamera.WorldToScreenPoint(target.position);
            // 确保目标在摄像机前方
            if (targetScreenPos.z < 0)
            {
                targetScreenPos *= -1;
            }
            Vector3 directionFromCenter = (targetScreenPos - screenCenter).normalized;
            // float aspect = Screen.width / (float)Screen.height / 2;
            // 根据屏幕的长宽比调整方向
            // directionFromCenter.y /= aspect;
            // 计算与屏幕边缘的交点-这里的计算很巧妙（分为两种情况，通过Min来处理）
            float x = screenCenter.y / Mathf.Abs(directionFromCenter.y);
            float y = screenCenter.x / Mathf.Abs(directionFromCenter.x);
            float d = Mathf.Min(x, y);
            // Vector3 edgePostion = screenCenter + directionFromCenter * d * aspect;
            Vector3 edgePostion = screenCenter + directionFromCenter * d;
            // 将z坐标设置为0以保持在UI层
            edgePostion.z = 0;
            indicator.position = edgePostion;
            // 计算角度
            float angle = Mathf.Atan2(directionFromCenter.y, directionFromCenter.x) * Mathf.Rad2Deg;
            // 旋转箭头以指向目标
            indicator.rotation = Quaternion.Euler(0, 0, angle + 90);
        }
    }
}
