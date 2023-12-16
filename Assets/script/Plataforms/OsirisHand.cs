using UnityEngine;

public class OsirisHand : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 1.0f;

    private float tiempoInicio;

    void Start()
    {
        tiempoInicio = Time.time;
    }

    void Update()
    {
        float tiempoTranscurrido = Time.time - tiempoInicio;
        float t = tiempoTranscurrido / velocidad;

        // Asegurarse de que t esté en el rango [0, 1]
        t = Mathf.Clamp01(t);

        // Interpolar entre puntoA y puntoB
        transform.position = Vector3.Lerp(puntoA.position, puntoB.position, t);

        // Puedes añadir rotación o escala también si es necesario
        // transform.rotation = Quaternion.Lerp(puntoA.rotation, puntoB.rotation, t);
        // transform.localScale = Vector3.Lerp(puntoA.localScale, puntoB.localScale, t);

        // Si t alcanza 1.0, el desplazamiento ha terminado
        if (t == 1.0f)
        {
            // Puedes agregar acciones adicionales cuando se completa el desplazamiento
            Debug.Log("Desplazamiento completado");
        }
    }
}

