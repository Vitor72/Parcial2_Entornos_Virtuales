using UnityEngine;

public class Puzzle_Colores : MonoBehaviour
{
    public Transform azul;
    public int num_azul = 1;

    public bool azul_presionado = false;

    public Transform rojo;
    public int num_rojo = 2;

    public bool rojo_presionado = false;

    public Transform verde;
    public int num_verde = 3;

    public bool verde_presionado = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("manos"))
        {
            azul_presionado = true;

            print("Presionado");
        }
        else
        {
            azul_presionado = false;
            print("Soltado");
        }
    }



}
