using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class TestClass
{
    public int i = 0;
}
public class GameObjTest : MonoBehaviour
{
    public UnityAction act;
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];
        // print(Random.Range(0,2));
        array.Select(x => x.ToString()).Cast<string>().ToArray();
        print(array.GetType().Name);
        CharacterController cc = new CharacterController();
        array.All(x => x > 10);
        act += Func;
        // StartCoroutine(Rand());
        // act += Func;
        List<int> l = new List<int> {4,3,5,1};
        // 返回值，和0比较，如果小于0，则认为第一个对象比第二个对象小
        // 这里我们 a < b 却返回 1 说明我们从大到小排序（默认是从小到大）
        // 或者说，返回-1则代表不变，
        l.Sort((a,b) => {
            if (a < b)
                return 1;
            else 
                return -1;
        });
        foreach (var item in l)
        {
            print(item);
        }
    }

    public void TestFun(out TestClass obj)
    {
        obj = new TestClass();
        obj.i = 10;
    }
    public IEnumerator Rand()
    {
        System.Random r = new System.Random();
        while(true)
        {
            
            print(r.Next(0,2));
            // print(Random.Range(0,2));
            yield return new WaitForSeconds(1);
        }
    }

    public void Func()
    {
        print("12314");
    }
    /// <summary>
    /// This function is called when the MonoBehaviour will be destroyed.
    /// </summary>
    void OnDestroy()
    {
        StopAllCoroutines();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
