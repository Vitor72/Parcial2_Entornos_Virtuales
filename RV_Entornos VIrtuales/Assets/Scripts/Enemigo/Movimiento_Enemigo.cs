using UnityEngine;
using UnityEngine.AI;
public class Movimiento_Enemigo : MonoBehaviour
{
    public NavMeshAgent enemigo;
    public float rango;

    public Transform punto_central;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemigo = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigo.remainingDistance <= enemigo.stoppingDistance)
        {
            Vector3 point;
            if(RandomPoint(punto_central.position, rango, out point))
            {
                Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
                enemigo.SetDestination(point);
            }
        }
    }

    bool RandomPoint(Vector3 centro, float range, out Vector3 resultado)
    {
        Vector3 punto_random = centro + Random.insideUnitSphere * range;
        NavMeshHit hit;
        if(NavMesh.SamplePosition(punto_random,out hit, 1.0f, NavMesh.AllAreas))
        {
            resultado = hit.position;
            return true;
        }
        resultado = Vector3.zero;
        return false;
    }
}
