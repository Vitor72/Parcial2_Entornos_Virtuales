using System.Net.Sockets;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Controlador_Puzzle : MonoBehaviour
{


    private int objetosPuestos = 0;
    private bool ganaste = false;
    public XRSocketInteractor[] objetos;



    void Start()
    {
        
    }
    private void OnEnable()
    {
        foreach(var objeto in objetos)
        {
            objeto.selectEntered.AddListener(ColcarObjeto);
            objeto.selectExited.AddListener(QuitarObjeto);
        }
    }

    private void OnDisable()
    {
        foreach (var objeto in objetos)
        {
            objeto.selectEntered.RemoveListener(ColcarObjeto);
            objeto.selectExited.RemoveListener(QuitarObjeto);
        }
    }

    private void ColcarObjeto(SelectEnterEventArgs args)
    {
        if (ganaste)
            return;
        objetosPuestos++;

        if(objetosPuestos >= objetos.Length)
        {
            ganaste = true;
            print("GANASTE");
        }

    }

    private void QuitarObjeto(SelectExitEventArgs args)
    {
        if (ganaste)
            return;
        objetosPuestos--;
        if(objetosPuestos < 0)
        {
            objetosPuestos = 0;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
