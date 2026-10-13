using UnityEngine;

public class Color : MonoBehaviour
{
    public MainPlayer mainPlayer;
    public Material material;
    public Renderer playerRender;
    void OnEnable()
    {
        mainPlayer = FindAnyObjectByType<MainPlayer>();
        mainPlayer.CambioColor += CambioColorPlayer;
    }

    void OnDisable()
    {
        mainPlayer.CambioColor -= CambioColorPlayer;
    }

    public void CambioColorPlayer(int health)
    {
       playerRender.material = material ;
    }
}
