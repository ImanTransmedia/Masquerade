using UnityEngine;
using Oculus;

public static class ControladorOculus
{
    
    public static void VibracionControl(float intensity)
    {
        OVRInput.Controller controller = OVRInput.GetActiveController();

        // Hace que el mando vibre con la intensidad dada
        OVRInput.SetControllerVibration(intensity, intensity, controller);
    }

    public static void PararControl()
    {
        // Detiene la vibraci�n del mando
        OVRInput.Controller controller = OVRInput.GetActiveController();
        OVRInput.SetControllerVibration(0, 0, controller);
    }

    public static void VibracionControlHaptico(AudioClip MiAudio)
    {
        OVRHapticsClip MiClip;
   
        MiClip = new OVRHapticsClip(MiAudio);

        foreach (var item in OVRHaptics.Channels)
        {
            item.Preempt(MiClip);
        }
        //OVRHaptics.Channels[1].Preempt(MiClip);
    }
}

