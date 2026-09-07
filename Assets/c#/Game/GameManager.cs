using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
     public InputActionReference launcheAction;
     public ObjectPooling PoolingBalls;
     public Camera camara;

     void OnEnable()
     {
         Debug.Log("OnEnable");
         launcheAction.action.Enable();
         launcheAction.action.performed += OnClickAction;
     }

     void OnDisable()
     {
         launcheAction.action.Disable();
         launcheAction.action.performed -= OnClickAction;
     }

     void OnClickAction(InputAction.CallbackContext param)
     {
         Debug.Log("Click");
         PoolingBalls.SpawnOnject(camara.transform.rotation, camara.transform.position);
     }
}
