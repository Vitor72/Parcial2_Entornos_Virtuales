using System;
using UnityEngine;

public class Bateria : MonoBehaviour
{
    public int cantidad_energia = 100;

    public Linterna linternaScript;



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
        if (cantidad_energia < 0)
        {
            cantidad_energia -= 5;
        }

        
    }

    public void cargar()
    {
        while (linternaScript.cantidad > 100)
        {
            descargar();
            linternaScript.cantidad += 2;
        }
    }    

}



