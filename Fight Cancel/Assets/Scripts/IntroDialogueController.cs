using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class IntroDialogueController : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public GameObject pantalla, popUp=null; 
    public string[] sentences; 
    public float speed;

    private int Index = 0;
    private bool click = true;
    private bool reset = false;
    PlaySoundEffect soundEffect;

    private void Start()
    {
        soundEffect = this.gameObject.GetComponent<PlaySoundEffect>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && click)
        {
            NextSentence();
            if (Index != sentences.Length)
                soundEffect.PlayThisSound();
            else soundEffect.StopSound();
        }
    }

    void NextSentence()
    {
        if (Index < sentences.Length)
        {
            click = false; 
            dialogueText.text = "";
            StartCoroutine(WriteSentence());
        }

        else if (Index == sentences.Length)
        {
            pantalla.SetActive(false);
            soundEffect.StopSound();

            if (popUp != null)
                popUp.SetActive(true);

            dialogueText.text = "";
            reset = true;
            Index = 0; 
        } 
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

    public void Activate()
    {
        pantalla.SetActive(true);
    }
}
