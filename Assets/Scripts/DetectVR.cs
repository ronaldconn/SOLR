using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    //set this variable to false to automatically start in emulated VR
    public bool startInVR = false;
    public GameObject xrOrigin;
    public GameObject desktopCharacter;
   
    void Start()
    {   
        if (startInVR)
        {
            var xrSettings = XRGeneralSettings.Instance;
            if (xrSettings == null)
            {
                Debug.Log($"XRGeneralSettings is null.");
                return;
            }

            var xrManager = xrSettings.Manager;
            if (xrManager == null)
            {
                Debug.Log($"XRManagerSettings is null.");
                return;
            }

            var xrLoader = xrManager.activeLoader;
            if (xrLoader == null)
            {
                Debug.Log($"XRLoader is null.");
                xrOrigin.SetActive(false);
                desktopCharacter.SetActive(true);
                return;
            }

            Debug.Log($"XRLoader is NOT null");
            xrOrigin.SetActive(true);
            desktopCharacter.SetActive(false);
        }
        else
        {
            xrOrigin.SetActive(false);
            desktopCharacter.SetActive(true);
            
        }
    }
}
