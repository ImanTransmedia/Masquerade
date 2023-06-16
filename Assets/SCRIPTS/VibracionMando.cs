using UnityEngine;
using OculusSampleFramework;

public class VibracionMando : MonoBehaviour
{  
    public Transform objetoA;
    public Transform objetoB;

    [SerializeField]private float maxDistance;

    void Update()
    {
        float distance = Vector3.Distance(objetoA.position, objetoB.position);
        float intensity = Mathf.Clamp01(1 - distance / maxDistance);

        OVRInput.Controller controller = OVRInput.GetConnectedControllers() & (OVRInput.Controller.LTouch | OVRInput.Controller.RTouch);
        OVRInput.SetControllerVibration(intensity, intensity, controller);
    }
}


