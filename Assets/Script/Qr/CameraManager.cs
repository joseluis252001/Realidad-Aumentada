using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Vuforia;
public class CameraManager : MonoBehaviour
{
    public RawImage image;
    public TextMeshProUGUI textDebug;
    public BarcodeBehaviour barcodeVuforia;
    public WebCamTexture webCamTexture;
    public Button button;
    

    public IEnumerator Start()
    {
        if (WebCamTexture.devices.Length == 0)
        {
            Debug.Log("No hay camaras en este dispositivo");
            yield break;
        }

        if (webCamTexture == null)
        {
            webCamTexture = new WebCamTexture(WebCamTexture.devices[0].name);
        }

        webCamTexture.Play();
        image.texture = webCamTexture;
    }

    public void onWebPage(string url)
    {
        url = textDebug.text;

        if (barcodeVuforia != null && textDebug.gameObject.activeInHierarchy)
        {
            Application.OpenURL(url);
        }
    }
    public void Update()
    {
         if(barcodeVuforia != null && barcodeVuforia.InstanceData != null)
         {
                textDebug.text = barcodeVuforia.InstanceData.Text;
         }
    }

}
