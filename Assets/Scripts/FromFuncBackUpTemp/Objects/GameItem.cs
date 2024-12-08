using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : MonoBehaviour
{
    public int ScoreValue => 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("碰撞了。");
        PlayerPickObj player = other.GetComponent<PlayerPickObj>();
        if (player != null)
        {
            player.PickUpItem(this);
        }
    }

    public void OnPickUp()
    {
        print("GameItem 执行，被碰撞了，可以播放音效等");
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
