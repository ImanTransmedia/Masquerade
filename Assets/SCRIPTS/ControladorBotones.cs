using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBotones : MonoBehaviour
{
    GameObject btnPiedra;
    GameObject btnFuego;
    GameObject btnAniFuego;
    public Animator animacionPiedra1;
    // Start is called before the first frame update
    void Start()
    {
        //animacionPiedra1 = GetComponent<Animator>();
    }

    public void botonPiedra1(string nombreEvento)
    {
        animacionPiedra1.SetBool(nombreEvento, true);
        //Debug.Log("ddd");
    }
}
