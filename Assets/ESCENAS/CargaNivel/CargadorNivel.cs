using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class CargadorNivel 
{
    public static string SiguienteNivel;

    public static void LoadLevel(string Nombre)
    {
        SiguienteNivel = Nombre;

        SceneManager.LoadScene("Carga");

    }
}
