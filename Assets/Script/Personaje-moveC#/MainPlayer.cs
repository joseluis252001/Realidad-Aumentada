using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public delegate void OnPlayerColor(int color); 
    public OnPlayerColor CambioColor;
    public void ReceiveDamage(int health)
    {
        health -= health;
        CambioColor?.Invoke(health);
    }
}
