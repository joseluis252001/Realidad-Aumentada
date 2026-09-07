using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public float speed;
    public GameObject target;
    

    public void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;
    }
}
