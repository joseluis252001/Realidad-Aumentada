using UnityEngine;
using System.Collections;

public class SpawnTargect : MonoBehaviour
{
    public GameObject ball;
    public int points;
    public int cantidad;
    public bool canasta;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBall();
    }
    //crear pelota
    //lanzar pelota
    //si cae pelota dentro de la canasta puntua. sino no
    // aun tienes cantidad de pelota,crea otra pelota. sino no
    public void SpawnBall()
    {
        if (cantidad >= 0)
        {
            GameObject newball = Instantiate(ball, transform.position, transform.rotation);
        }
        else
        {
            return;
        }
        
    }
    public void Score()
    {
        if (canasta == true)
        {
            points++;
        }
        else
        {
            points = points;
        }
    }
    
}
