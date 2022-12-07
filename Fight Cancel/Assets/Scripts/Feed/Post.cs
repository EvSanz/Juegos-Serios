using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Post : MonoBehaviour
{
    public GameObject post, panelOpciones; 
    public Text postTexto, comentarioTexto;
    public Image postImage, comentarioImage; 

    public void PostText()
    {
        if (postTexto != null)
            comentarioTexto.text = postTexto.text;

        DesactivarPaneles(); 
    }

    public void PostImage()
    {
        if (postImage != null)
            comentarioImage.sprite = postImage.sprite;

        DesactivarPaneles(); 
    }

    void DesactivarPaneles()
    {
        post.SetActive(true);
        panelOpciones.SetActive(false);
    }
}
