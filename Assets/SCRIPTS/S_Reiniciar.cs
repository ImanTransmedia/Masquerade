using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class S_Reiniciar : MonoBehaviour
{

    [Header("UI")]
    [Space(5)]
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject UIIndicativo;
    [Space(10)]

    [Header("Control")]
    [Space(5)]
    [SerializeField] private bool UsarControl;
    [SerializeField] private bool estado;
    [Space(10)]

    [Header("Niveles")]
    [Space(5)]
    [SerializeField] private string nombreNivel;
    

    public void Reiniciar()
    {
        CargadorNivel.LoadLevel(SceneManager.GetActiveScene().name);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Iniciar()
    {
        CargadorNivel.LoadLevel(nombreNivel);
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Start) && UsarControl == true)
        {
            estado = !estado;
        }

        if (estado)
        {
            // Hacer algo si el estado es verdadero
            if (panel != null) { panel.SetActive(true); }

            Time.timeScale = 0;
            AudioListener.pause = true;

            if (UIIndicativo!=null)
            UIIndicativo.SetActive(false);
        }
        else
        {
            // Hacer algo si el estado es falso
            if (panel != null) { panel.SetActive(false); }

            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }
}
