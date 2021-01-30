using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In : MonoBehaviour
{
    public bool isOnObj = false;
    private LineDrawer[] lineDrawer; 
    public LineDrawer bruh;
    public bool lnCreated = false;

    public void UpdatelnCreated(bool boollncreated){
        lnCreated = boollncreated;
        //Debug.Log("Line created = " + lnCreated);
        lineDrawer = GameObject.FindObjectsOfType<LineDrawer> ();
    }

    void OnMouseOver()
    {
        if (lnCreated == true){
            Debug.Log("Mouse is over In");
            isOnObj = true;
            foreach(LineDrawer i in lineDrawer){
                i.UpdateIsOnObj(isOnObj);
            }
            GetComponentInParent<Componente>().conectando = true;
        } 
    }

    void OnMouseExit()
    {
        if (lnCreated == true){
            //Debug.Log("Mouse is NOT over In");
            isOnObj = false;
            foreach(LineDrawer i in lineDrawer){
                i.UpdateIsOnObj(isOnObj);
            }
            GetComponentInParent<Componente>().conectando = false;
        }

    }
}
