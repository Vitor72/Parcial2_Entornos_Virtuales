using UnityEngine;
using System.Collections;


public class Bateria_Generador_Grande : MonoBehaviour
{
    public int energia_pro_disponible = 150;
    public Light luz;
    private Coroutine descargando;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (energia_pro_disponible == 0)
        {
            luz.enabled = false;
        }
    }
    public void PausarDescarga()
    {
        if (descargando != null)
        {
            StopCoroutine(TiempoDescarga());
            descargando = null;
        }
    }

    private IEnumerator TiempoDescarga()
    {
        while (energia_pro_disponible > 0)
        {
            descargar();
            yield return new WaitForSeconds(3.5f);
        }
        descargando = null;
    }

    public void descargar()
    {
        if (energia_pro_disponible > 0)
        {
            energia_pro_disponible -= 1;
        }
    }

    public void SeDescarga()
    {
        if (descargando == null)
        {
            descargando = StartCoroutine(TiempoDescarga());
        }
    }
}