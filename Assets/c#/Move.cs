using UnityEngine;
using UnityEngine;
using Vuforia;

public class Move : MonoBehaviour
{
   public GameObject imageTarget;
    
    void Update()
    {
        transform.LookAt(imageTarget.transform);
    }
}
