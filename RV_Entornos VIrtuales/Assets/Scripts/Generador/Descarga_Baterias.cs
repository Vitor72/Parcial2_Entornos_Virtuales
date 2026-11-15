using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Descarga_Baterias : MonoBehaviour
{
    public BateriaGenerador_pequeña bateria;

    public Bateria_Generador_Grande bateria_pro;
    private Coroutine reduccion;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void perdiste()
    {
        if (bateria.energia_dispobible == 0 && bateria_pro.energia_pro_disponible == 0)
        {

        }
    }
}
