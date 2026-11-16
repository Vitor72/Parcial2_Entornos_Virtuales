using NUnit.Framework;
using System;
using UnityEngine;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.XR.Interaction.Toolkit.Interactables;


public class Linterna : MonoBehaviour
{
    public GameObject luz;
    public GameObject raycast;
    public float cantidad = 100f;
    private bool luz_activada = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cantidad <= 0)
        {
            luz.SetActive(false);

        }
        if(luz_activada)
        {
            cantidad -= 0.5f * Time.deltaTime;
        }
        
    }
    public void Activar()
    {
        luz_activada = true;
        if (luz_activada == true && cantidad > 0)
        {
            luz.SetActive(true);
            raycast.SetActive(true);
        }
    }
    public void Desactivar()
    {
        luz_activada = false;
        luz.SetActive(false);
        raycast.SetActive(false);
    }    
}
