using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publish : MonoBehaviour
{
    public GameObject[] options; 

    public void OpenOptionsPanel()
    {
        if (GameManager.GetInstance() != null)
        {
            if (GameManager.GetInstance().GetPost() < options.Length)
            {
                options[GameManager.GetInstance().GetPost()].SetActive(true);
                GameManager.GetInstance().AddPost();
            }

            else
                print("No puedes poner más comentarios"); 
        }   
    }
}
