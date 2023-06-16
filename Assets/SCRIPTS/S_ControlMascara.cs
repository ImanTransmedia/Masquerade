using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_ControlMascara : MonoBehaviour
{
    public string NombreJugador;

    void Start()
    {
        
    }


    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.name == NombreJugador)
        {
            Destroy(gameObject);
        }
    }
}
