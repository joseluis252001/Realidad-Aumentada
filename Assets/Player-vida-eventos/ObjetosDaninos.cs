using UnityEngine;

public class ObjetosDaninos : MonoBehaviour
{
    public int vida = 100;
    public int danio = 10;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entro");
        
        if (other.CompareTag("Enemy"))
        {
            vida -= danio;
            Debug.Log("¡Te pegaron! Vida: " + vida);

            if (vida <= 0)
            {
                vida = 0;
                Debug.Log("El player murió");
            }
        }

        GetComponent<MainPlayer>().ReceiveDamage(danio);
    }
}
