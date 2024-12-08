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
        print("��ײ�ˡ�");
        PlayerPickObj player = other.GetComponent<PlayerPickObj>();
        if (player != null)
        {
            player.PickUpItem(this);
        }
    }

    public void OnPickUp()
    {
        print("GameItem ִ�У�����ײ�ˣ����Բ�����Ч��");
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
