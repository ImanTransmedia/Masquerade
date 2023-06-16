using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using System;


public class Colider : MonoBehaviour
{
    public UnityEvent triggerEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (!Application.isPlaying)
            return;
        if (triggerEnter != null)
            triggerEnter.Invoke();
    }


}




