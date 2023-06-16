using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibracion3 : MonoBehaviour
{
    public static vibracion3 singleton;

    private void Start()
    {
        if (singleton && singleton != this)
        
            Destroy(this);
        
        else
        
            singleton = this;
        
    }

    public void Vibracion(AudioClip AudioVibracion, OVRInput.Controller Controlador)
    {
        OVRHapticsClip clip = new OVRHapticsClip(AudioVibracion);

        if (Controlador==OVRInput.Controller.LTouch)
        {
            OVRHaptics.LeftChannel.Preempt(clip);
        }
        else if (Controlador == OVRInput.Controller.RTouch)
        {
            OVRHaptics.RightChannel.Preempt(clip);
        }
    }
}
