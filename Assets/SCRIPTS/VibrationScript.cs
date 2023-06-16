using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;

public class VibrationScript : MonoBehaviour
{
    OVRHapticsClip MiClip;
    public AudioClip Audio;

    // Start is called before the first frame update
    void Start()
    {
        MiClip = new OVRHapticsClip(Audio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        OVRHaptics.LeftChannel.Mix(MiClip);
    }
}
