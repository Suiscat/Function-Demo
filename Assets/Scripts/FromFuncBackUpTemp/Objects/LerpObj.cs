using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public enum E_Speed_Type
{
    Constant,
    Variable,
}

public class LerpObj : MonoBehaviour
{
    public E_Speed_Type lerpType = E_Speed_Type.Constant;

    public Transform targetObj;

    public float baseSpeed = 5f;

    private Vector3 oldPos;
    private Vector3 oldTargetPos;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        oldPos = transform.position;
        oldTargetPos = targetObj.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (targetObj == null)
            throw new ArgumentNullException("Œ¥…Ë÷√target");
        //if (targetObj == null)
        //{
        //    Debug.LogWarning("targetObj, Œ¥…Ë÷√");
        //    return;
        //}
        switch (lerpType)
        {
            case E_Speed_Type.Constant:
                if (oldTargetPos != targetObj.transform.position)
                {
                    time = 0;
                    oldTargetPos = targetObj.transform.position;
                    oldPos = transform.position;
                }
                transform.position = Vector3.Lerp(oldPos, targetObj.position, time);
                time += baseSpeed * Time.deltaTime;
                break;
            case E_Speed_Type.Variable:
                transform.position = Vector3.Lerp(transform.position, targetObj.position, Time.deltaTime * baseSpeed);
                break;
            default:
                break;
        }
    }
}
