using UnityEngine;

public class Contrarestar_Enemigo : MonoBehaviour
{
    public Movimiento_Enemigo Enemigo;
    private int rango = 28;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray raycast = new Ray(gameObject.transform.position, gameObject.transform.forward);
        Debug.DrawRay(raycast.origin, raycast.direction * 30f, Color.green);
        if(Physics.Raycast(raycast, out hit,rango))
        {
            if(hit.collider.GetComponent<Movimiento_Enemigo>() == true)
            {
                hit.collider.GetComponent<Movimiento_Enemigo>().enabled = false;
                Destroy(hit.collider.gameObject, 1);
                /*
                Enemigo.BajarPortal();
                Destroy(hit.collider.gameObject, 2);*/
            }
        }
    }
}
