using System.Collections;
using TMPro;
using UnityEngine;

public class MostrarTextos : MonoBehaviour
{
    public TextMeshProUGUI textoTMP;
    public string[] textos;
    public float delayEntreTextos = 2f;
    public float velocidadTexto = 0.4f;

    void Start()
    {
        StartCoroutine(MostrarTextosConDelay());
    }

    IEnumerator MostrarTextosConDelay()
    {
        foreach (string texto in textos)
        {
            yield return StartCoroutine(MostrarTextoLetraPorLetra(texto));
            yield return new WaitForSeconds(delayEntreTextos);
        }

        // Puedes agregar acciones adicionales cuando se muestran todos los textos
        Debug.Log("Todos los textos han sido mostrados");
    }

    IEnumerator MostrarTextoLetraPorLetra(string texto)
    {
        textoTMP.text = ""; // Inicializar el texto a vacío

        foreach (char letra in texto)
        {
            textoTMP.text += letra; // Agregar la letra actual al texto
            yield return new WaitForSeconds(velocidadTexto); // Esperar antes de la siguiente letra
        }
    }
}
