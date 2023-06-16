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
        // Obtener la direcci�n y distancia de la c�mara al objeto
        Vector3 direccion = transform.position - camara.transform.position;
        float distancia = direccion.magnitude;

        // Si la distancia es mayor a la distancia m�xima, no destruir el objeto
        if (distancia > distanciaMaxima)
        {
            return;
        }

        // Obtener el �ngulo entre la direcci�n y la cara frontal del objeto
        float angulo = Vector3.Angle(direccion, transform.forward);

        // Si el �ngulo es menor a 90 grados, verificar si los rayos est�n alineados
        if (angulo < 90f)
        {
            RaycastHit hitCamara;
            RaycastHit hitObjeto;

            // Disparar un rayo desde la c�mara hacia el objeto
            if (Physics.Raycast(camara.transform.position, direccion, out hitCamara, distanciaMaxima, capasAConsiderar))
            {
                // Disparar un rayo desde el objeto hacia la c�mara
                if (Physics.Raycast(transform.position, -direccion, out hitObjeto, distanciaMaxima, capasAConsiderar))
                {
                    // Si los rayos est�n alineados, destruir el objeto
                    if (hitCamara.collider.gameObject == gameObject && hitObjeto.collider.gameObject == camara.gameObject)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }
    }
}
