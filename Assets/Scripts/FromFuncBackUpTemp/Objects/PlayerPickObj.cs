using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickObj : MonoBehaviour
{
    private int _nowScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PickUpItem(GameItem item)
    {
        _nowScore += item.ScoreValue;
        item.OnPickUp();
        print($"当前分数：{_nowScore}");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
