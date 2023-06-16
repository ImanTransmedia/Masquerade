using UnityEngine;
using UnityEngine.XR;

public class vibracion2 : MonoBehaviour
{
    //public OVRGrabbable agarre;
    public AudioClip Audio;

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        vibracion3.singleton.Vibracion(Audio, OVRInput.Controller.All);
    }

    
}
