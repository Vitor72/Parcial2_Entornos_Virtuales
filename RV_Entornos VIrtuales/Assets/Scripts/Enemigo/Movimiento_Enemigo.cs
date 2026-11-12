using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class Movimiento_Enemigo : MonoBehaviour
{
    public float velocidad_de_subida = 1f;
    public float tiempo_subida = 10f;
    public bool subiendo = false;

    public bool bajando = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    private IEnumerator SubirPortal()
    {
        subiendo = true;
        bajando = false;
        float time = 0f;
        while(time < tiempo_subida)
        {
            transform.Translate(Vector3.up * velocidad_de_subida * Time.deltaTime);

            time += Time.deltaTime;
            yield return null;
        }
        subiendo = false;
    }

    public IEnumerator BajarPortal()
    {
        bajando = true;
        subiendo = false;
        float time = 0f;
        while (time < tiempo_subida)
        {
            transform.Translate(Vector3.down * velocidad_de_subida * Time.deltaTime);

            time += Time.deltaTime;
            yield return null;
        }
        bajando = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("portal") && !subiendo)
        {
            StartCoroutine(SubirPortal());
        }

    }



}

