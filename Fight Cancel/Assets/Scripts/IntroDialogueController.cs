using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class IntroDialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject pantalla; 
    public string[] sentences; 
    public float speed;

    private int Index = 0;
    private bool click = true; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && click)
            NextSentence(); 
    }

    void NextSentence()
    {
        if (Index < sentences.Length)
        {
            click = false; 
            dialogueText.text = "";
            StartCoroutine(WriteSentence());
        }

        else
            pantalla.SetActive(false);
    }

    IEnumerator WriteSentence()
    {
        foreach (char character in sentences[Index].ToCharArray())
        {
            dialogueText.text += character;
            yield return new WaitForSeconds(speed); 
        }

        Index++;
        click = true; 
    }
}
