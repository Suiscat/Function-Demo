using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyUIReview : MonoBehaviour
{
    public Button btnTest;
    // Start is called before the first frame update
    void Start()
    {
        if (btnTest != null) 
        {
            btnTest.onClick.AddListener(() => {
                btnTest.image.sprite = Resources.Load<Sprite>("复杂形状");
            });
        }
        using (FileStream fs = File.Open("", FileMode.Open))
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickReact()
    {
        print("被点击了。。。");
    }
}
