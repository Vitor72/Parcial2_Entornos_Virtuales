using System;
using System.Collections;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public int cantidad_energia = 100;

    public Linterna linternaScript;

    private Coroutine cargando;

    public 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void descargar()
    {
        if (cantidad_energia >= 0)
        {
            cantidad_energia -= 5;
        }

        
    }

    public void cargar()
    {
        if (cargando == null)
        {
            cargando = StartCoroutine(tiempocarga());
        }
        /*
        while (linternaScript.cantidad < 100)
        {
            descargar();
            linternaScript.cantidad += 2;
        }*/
    }

    public void pausarcarga()
    {
        if(cargando != null)
        {
            StopCoroutine(tiempocarga());
            cargando = null;
        }
    }


    private IEnumerator tiempocarga()
    {
        while (linternaScript.cantidad < 100f && cantidad_energia > 0)
        {
            descargar();
            linternaScript.cantidad += 2f;
            yield return new WaitForSeconds(0.5f);
        }
        cargando = null;
    }



}



