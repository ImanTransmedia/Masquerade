using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cargando : MonoBehaviour
{

    void Start()
    {
        string NivelACargar = CargadorNivel.SiguienteNivel;

        StartCoroutine(this.HacerCarga(NivelACargar));
    }

    IEnumerator HacerCarga(string Nivel)
    {
        //Solo para desarrollo
        yield return new WaitForSeconds(1f);

        //Indica cuando el nivel esta cargado
        AsyncOperation operation = SceneManager.LoadSceneAsync(Nivel);

        while (operation.isDone == false)
        {
            yield return null;
        }
    }


}
