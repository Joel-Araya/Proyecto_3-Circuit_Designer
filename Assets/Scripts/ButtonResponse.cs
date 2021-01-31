using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
// Envía una señal al boton del canvas para que oculte el canvas
///</summary>
public class ButtonResponse : MonoBehaviour
{

    public void cerrarUITextField()
    {
        FindObjectOfType<UI_InputWindow>().setHide();
        //Debug.Log("CerrarVentana");
    }
}
