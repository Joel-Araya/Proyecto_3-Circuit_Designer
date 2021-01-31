using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCambioModo : MonoBehaviour
{
    public bool modoSimulacion = false;

    //GameObject boton = GameObject.FindGameObjectWithTag("ModoDiseno.png");
    public Sprite spriteDiseno;
    public Sprite spriteSimulacion;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!modoSimulacion)
        {
            modoSimulacion = true;
            //Debug.Log("LA simulación está " + modoSimulacion);
            spriteRenderer.sprite = spriteSimulacion;
            transform.localScale = new Vector3(2.5f, 2.5f, 0f);
        }

        else
        {
            modoSimulacion = false;
            //Debug.Log("La simulación está " + modoSimulacion);
            spriteRenderer.sprite = spriteDiseno;
            transform.localScale = new Vector3(5f, 5f, 0f);
        }
    }
}
