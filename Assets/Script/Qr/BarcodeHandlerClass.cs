using UnityEngine;
using Vuforia;
using TMPro;

public class BarcodeHandlerClass : MonoBehaviour
{
   public TextMeshProUGUI textDebug;
   public BarcodeBehaviour barcodeVuforia;

   #if UNITY_EDITOR
      void OnValidate()
      {
         if (barcodeVuforia == null)
              barcodeVuforia = GetComponent<BarcodeBehaviour>();
      }
   #endif

     void Update()
     {
        if (barcodeVuforia != null && barcodeVuforia.InstanceData !=null)
       {
           textDebug.text = barcodeVuforia.InstanceData.Text;   
        }
    } 
}
