using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Post : MonoBehaviour
{
    public GameObject post, panelOpciones; 
    public Text comentarioTexto;
    public Image postImage, comentarioImage;
    public string texto;
    public int likes, dislikes;

    public void PostText()
    {
        if (texto != null)
            comentarioTexto.text = texto;

        DesactivarPaneles();
        GameManager.GetInstance().addMyLikes(likes);
        GameManager.GetInstance().addMyDislikes(dislikes);
    }

    public void PostImage()
    {
        if (postImage != null)
            comentarioImage.sprite = postImage.sprite;
           
        DesactivarPaneles();
        GameManager.GetInstance().addMyLikes(likes);
        GameManager.GetInstance().addMyDislikes(dislikes);
    }

    void DesactivarPaneles()
    {
        post.SetActive(true);
        panelOpciones.SetActive(false);
    }
}