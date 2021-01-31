using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class In : MonoBehaviour
{
    public bool isOnObj = false;
    private LineDrawer[] lineDrawer; 
    public LineDrawer bruh;
    public bool lnCreated = false;
    ///<summary>
    // Actualiza lnCreated, quien verifica que el cable haya sido creado, para preparar a 
    // In a recibir dicho cable
    ///</summary>

    public void UpdatelnCreated(bool boollncreated){
        lnCreated = boollncreated;
        //Debug.Log("Line created = " + lnCreated);
        lineDrawer = GameObject.FindObjectsOfType<LineDrawer> ();
    }

    // Detecta cuando el mouse está por encima de IN 
    void OnMouseOver()
    {
        if (lnCreated == true){
            //Debug.Log("Mouse is over In");
            isOnObj = true;
            foreach(LineDrawer i in lineDrawer){
                i.UpdateIsOnObj(isOnObj);
            }
            GetComponentInParent<Componente>().conectando = true;
        } 
    }

    // Detecta cuado el mouse ya no esta sobre IN
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
