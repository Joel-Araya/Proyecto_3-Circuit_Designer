using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Out : MonoBehaviour
{
    public bool isOnObj = false;
    //private LineDrawer lineDrawer; 
    public LineDrawer bruh;
    private bool lnCreated = false;

    private In[] inScript;

    void Awake(){
        inScript = GameObject.FindObjectsOfType<In> ();
    }
    
    void OnMouseDown(){
        Instantiate(bruh,transform.position, transform.rotation);
        lnCreated = true;
        //lineDrawer = GameObject.FindObjectOfType<LineDrawer> ();
        foreach(In i in inScript){
                i.UpdatelnCreated(lnCreated);
            }
    }

    void OnMouseOver()
    {            
        Debug.Log("Mouse is over OUT");
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is NOT over OUT");
    }
}
