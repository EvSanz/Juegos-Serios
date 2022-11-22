using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject imagenes;

    void Start()
    {
            imagenes.SetActive(false); 
    }

    void OnMouseDown()
    {
        if (GameManager.instance != null)
        {
            if (GameManager.instance.HowManyPost())
            {
                GameManager.instance.AddPost(); 
                imagenes.SetActive(true);
            }
        } 
    }
}
