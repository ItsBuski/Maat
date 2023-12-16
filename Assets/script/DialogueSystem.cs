using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI barText;

    [SerializeField] string text;

    private State state = State.COMPLETED;

    private enum State
    {
        PLAYING, COMPLETED
    }

    void OnEnable()
    {
        barText.enabled = true;
        StartCoroutine(TypeText(text));
    }

    private IEnumerator TypeText(string text)
    {
        barText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;

        while (state != State.COMPLETED)
        {
            barText.text += text[wordIndex];
            yield return new WaitForSeconds(0.05f);
            if (++wordIndex == text.Length)
            {
                state = State.COMPLETED;
            }
        }

        if (state == State.COMPLETED)
        {

            yield return new WaitForSeconds(5.0f);
            barText.enabled = false;

        }
    }

    
}
