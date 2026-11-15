using UnityEngine;
using System.Collections;

public class BateriaGenerador_pequeña : MonoBehaviour
{
    public int energia_dispobible = 100;
    public GameObject luz;
    private Coroutine descargando;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (energia_dispobible == 0)
        {
            luz.SetActive(false);
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
        while (energia_dispobible > 0)
        {
            descargar();
            yield return new WaitForSeconds(2.5f);
        }
        descargando = null;
    }

    public void descargar()
    {
        if (energia_dispobible > 0)
        {
            energia_dispobible -= 1;
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
