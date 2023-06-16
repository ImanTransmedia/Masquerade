using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaRotationSky : MonoBehaviour
{
    public float velocidadRotation;
    public float position;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * velocidadRotation + position);
    }
}
