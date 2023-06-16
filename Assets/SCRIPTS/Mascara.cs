using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mascara : MonoBehaviour
{
    public GameObject destello;
    public GameObject mascara;
    public GameObject diablo;
    public AudioSource sonidoMascara;
   // public GameObject sonidoEntorno;
    //public GameObject Timeline;
    public GameObject Audios;

    public GameObject Instrucciones;

    public GameObject Cielo;
    

    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other){

       if (other.gameObject.tag == "mascara"){

            mascara.SetActive(false);
            destello.SetActive(true);
            StartCoroutine(Tiempodestello3());
            //sonidoEntorno.SetActive(true);

            //Instrucciones.SetActive(true);
            //SkuboxController cielo = gameObject.GetComponent<SkuboxController>();

          //  SkuboxController cielo = Cielo.GetComponent<SkuboxController>();

           // cielo.PlayDia();
            //cielo.CambiarSkybox();

        }
        }
        

    IEnumerator Tiempodestello3()
    {
        yield return new WaitForSeconds(0.3f);
        diablo.SetActive(true);
        //Timeline.SetActive(true);
        Audios.SetActive(false);

    }


}

