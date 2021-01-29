﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineDrawer : MonoBehaviour
{
    private LineRenderer lineRend;
    private Vector2 mousePos;
    private Vector2 startmousePos;
    private bool readyLn;
    private bool lnDone = false;

    private int cornerPoint;
    private int lastPoint = 1;

    private float distance;

    void Start()
    {
        startmousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lineRend = GetComponent<LineRenderer>();
        lineRend.positionCount = 2;
        lineRend.SetPosition(0, new Vector3(startmousePos.x, startmousePos.y, 0f));
    }

    public void UpdateIsOnObj(bool isOnObj){
        readyLn = isOnObj;
        Debug.Log("bruh"+readyLn);
    }

    void Update()
    {
            if (lnDone == false)
            {
                if (Input.GetMouseButton(0))
                {
                    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    lineRend.SetPosition(lastPoint, new Vector3(mousePos.x, mousePos.y, 0f));
                    distance = (mousePos - startmousePos).magnitude;
                }

                if (Input.GetMouseButtonUp(0) && readyLn == true)
                {
                    mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    lineRend.SetPosition(lastPoint, new Vector3(mousePos.x, mousePos.y, 0f));
                    lnDone = true;
                }

                if (Input.GetMouseButtonUp(0) && readyLn == false)
                {
                    /*mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    lineRend.SetPosition(1, new Vector3(startmousePos.x, startmousePos.y, 0f));*/
                    Destroy(this.gameObject);
                }

                if (Input.GetMouseButtonUp(1))
                {
                    lineRend.positionCount += 1;
                    Debug.Log(lineRend.positionCount);
                    cornerPoint = lineRend.positionCount-2;
                    lastPoint +=1;
                    lineRend.SetPosition(cornerPoint, new Vector3(mousePos.x, mousePos.y, 0f));
                }
        }
    }
}
