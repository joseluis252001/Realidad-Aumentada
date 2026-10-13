using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovimiento : MonoBehaviour
{
    public float velocidad;
    private Rigidbody rb;
    private Vector3 direccion;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direccion = new Vector3(x, 0f, z).normalized;
    }

    void FixedUpdate()
    {
        Vector3 movimiento = direccion * velocidad;
        rb.linearVelocity = new Vector3(movimiento.x, rb.linearVelocity.y, movimiento.z);
    }
}

    //traer solo el salto del personaje si choca con el suelo ya no salte