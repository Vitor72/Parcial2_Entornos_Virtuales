using UnityEngine;

public class Puzzle_Colores : MonoBehaviour
{
    public int num;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(num == 12)
        {
            print("Ganaste");
        }
    }

    public void SumarAzul()
    {
        num += 1;
    }
    public void SumarRojo()
    {
        num += 2;
    }
    public void SumarAmarilloojo()
    {
        num += 3;
    }
}
