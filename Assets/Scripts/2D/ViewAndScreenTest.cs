using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewAndScreenTest : MonoBehaviour
{
    public Transform target;
    private Camera _camera => Camera.main;
    public Image imgArrow;
    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 20, 200, 20), "targetPos:" + target.position);
        GUI.Label(new Rect(10, 40, 200, 20), "ViewPortPos:" + GetViewPortPos());
        GUI.Label(new Rect(10, 60, 300, 20), "WordToScreenPos:" + GetScreenPos());
        GUI.Label(new Rect(10, 80, 300, 20), "Mouse Pos:" + Input.mousePosition);
        GUI.Label(new Rect(10, 100, 300, 20), "Screen To Word:" + _camera.ScreenToWorldPoint(Input.mousePosition));
    }

    string GetViewPortPos()
    {
        return _camera.WorldToViewportPoint(target.position).ToString();
    }

    string GetScreenPos()
    {
        return _camera.WorldToScreenPoint(target.position).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (imgArrow == null) return;
        Vector3 center = new Vector3(Screen.width, Screen.height, 0) / 2;
        Vector3 centerDir = (Input.mousePosition - center).normalized;
        float angle = Mathf.Atan2(centerDir.y, centerDir.x) * Mathf.Rad2Deg;
        imgArrow.transform.rotation = Quaternion.Euler(0, 0, angle + 90);
    }
}
