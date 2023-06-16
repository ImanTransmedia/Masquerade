using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAscaraTest : MonoBehaviour
{
    public AudioSource AudioSourceDiablo;
    public AudioSource AudioSourceEntorno;
    public AudioClip ESC2DIABLOYATMOS;
    public AudioClip ESC2MUSICA;
    public AudioClip ESC3DiabloENG;
    public AudioClip ESC4DiabloENG;
    public AudioClip ESC4DiabloyAtmosENG;
    public AudioClip ESC4MUSICAENG;
    public void audioESC2()
    {
        
        
    }
    private void Start()
    {
        AudioSourceDiablo.clip = ESC2DIABLOYATMOS;
        AudioSourceEntorno.clip = ESC2MUSICA;

        AudioSourceDiablo.Play();
        AudioSourceEntorno.Play();
        StartCoroutine(Cambio());
        
    }

    IEnumerator Cambio()
    {
        yield return new WaitForSeconds(125.958f);
        AudioSourceDiablo.clip = ESC3DiabloENG;
        AudioSourceDiablo.Play();
        StartCoroutine(Cambio2());
    }
    IEnumerator Cambio2()
    {
        yield return new WaitForSeconds(125.958f);
      /*  AudioSourceDiablo.clip = ESC4DiabloENG;
        AudioSourceDiablo.Play();*/
        StartCoroutine(Cambio3());
    }
    IEnumerator Cambio3()
    {
        yield return new WaitForSeconds(66.500f);
        AudioSourceDiablo.clip = ESC4DiabloyAtmosENG;
        //AudioSourceEntorno.clip = ESC4MUSICAENG;
        AudioSourceDiablo.Play();
        //AudioSourceEntorno.Play();
        
    }
}
