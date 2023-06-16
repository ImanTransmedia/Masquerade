using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("funciona");

        if (other.gameObject.name == "huella")
        {

            Debug.Log("funciona");

        }
    }
}
