using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkuboxController : MonoBehaviour
{
    public Material material;
    [SerializeField] private Animator animacionSky;
    
    public void CambiarSkybox()
    {
        RenderSettings.skybox = material;
    }

    public void PlayDia()
    {
        animacionSky.Play("Noche-Dia");
    }

        
    
}
