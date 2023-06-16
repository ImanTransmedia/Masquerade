using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorCara : MonoBehaviour
{
    private void Start()
    {
        //gameObject.SetActive(false);
        this.GetComponent<BoxCollider>().enabled = false;
    }
    public void DetectorDeCaraActivo()
    {
        //gameObject.SetActive(true);

        this.GetComponent<BoxCollider>().enabled = true;
    }
    public void DetectorDeCaraDesactivo()
    {
        //gameObject.SetActive(false);
        this.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnApplicationQuit()
    {
        //gameObject.SetActive(true);
        this.GetComponent<BoxCollider>().enabled = true;

    }



}
