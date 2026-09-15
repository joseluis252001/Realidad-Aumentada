using System;
using System.Collections;
using UnityEngine;

public class BasketBall : MonoBehaviour
{
    public  Rigidbody rb;
    private void OnTriggerEnter(Collider collider)
    {
        gameObject.SetActive(false);

    }

    void OnEnable()
    {
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(transform.forward * 15, ForceMode.Impulse);
        StartCoroutine(RoutineDisable());
    }

    IEnumerator RoutineDisable()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
