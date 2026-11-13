using UnityEngine;
using System.Collections;

public class Respawneo : MonoBehaviour
{
    public GameObject enemigo;
    public GameObject punto_de_respawn;

    const int min_pos = -5;
    const int max_pos = 5;

    const int min_posz = 4;
    const int max_posz = 6;

    void Start()
    {
        StartCoroutine(Instanciarenemgios());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Instanciarenemgios()
    {
        while(true)
        {
            int randomx = Random.Range(min_pos, max_pos);
            int randomZ = Random.Range(min_posz, max_posz);
            Vector3 posicionrandom = new Vector3(randomx, -0, randomZ);
            Instantiate(enemigo, posicionrandom, Quaternion.identity, punto_de_respawn.transform);
            
            yield return new WaitForSeconds(25.5f);
        }

    }



}
