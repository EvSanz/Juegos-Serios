using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publish : MonoBehaviour
{
    public GameObject[] options;
    public GameObject warning; 

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
                warning.SetActive(true); 
        }   
    }
}
