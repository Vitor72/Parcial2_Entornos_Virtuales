using UnityEngine;

public class Mirar_Jugador : MonoBehaviour
{
    public Transform jugador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador != null)
        {
            transform.LookAt(jugador);
        }
    }
}
