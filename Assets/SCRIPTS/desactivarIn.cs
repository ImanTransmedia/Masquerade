using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivarIn : MonoBehaviour
{
    [SerializeField] private GameObject Indicativo;


    private void OnTriggerEnter(Collider other)
    {
        Indicativo.SetActive(false);
    }
}
