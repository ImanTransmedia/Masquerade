using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba_mascara : MonoBehaviour
{
    public Camera camara;
    public float distanciaMaxima = 10f;
    public LayerMask capasAConsiderar;

    private void Update()
    {
        // Obtener la dirección y distancia de la cámara al objeto
        Vector3 direccion = transform.position - camara.transform.position;
        float distancia = direccion.magnitude;

        // Si la distancia es mayor a la distancia máxima, no destruir el objeto
        if (distancia > distanciaMaxima)
        {
            return;
        }

        // Obtener el ángulo entre la dirección y la cara frontal del objeto
        float angulo = Vector3.Angle(direccion, transform.forward);

        // Si el ángulo es menor a 90 grados, verificar si los rayos están alineados
        if (angulo < 90f)
        {
            RaycastHit hitCamara;
            RaycastHit hitObjeto;

            // Disparar un rayo desde la cámara hacia el objeto
            if (Physics.Raycast(camara.transform.position, direccion, out hitCamara, distanciaMaxima, capasAConsiderar))
            {
                // Disparar un rayo desde el objeto hacia la cámara
                if (Physics.Raycast(transform.position, -direccion, out hitObjeto, distanciaMaxima, capasAConsiderar))
                {
                    // Si los rayos están alineados, destruir el objeto
                    if (hitCamara.collider.gameObject == gameObject && hitObjeto.collider.gameObject == camara.gameObject)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
