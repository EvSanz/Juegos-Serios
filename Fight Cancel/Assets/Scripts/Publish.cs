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
            options[GameManager.GetInstance().GetPost()].SetActive(true);
            GameManager.GetInstance().AddPost(); 
        }   
    }
}
