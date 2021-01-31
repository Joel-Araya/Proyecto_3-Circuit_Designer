using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonResponse : MonoBehaviour
{

    public void cerrarUITextField()
    {
        FindObjectOfType<UI_InputWindow>().setHide();
        Debug.Log("CerrarVentana");
    }
}
