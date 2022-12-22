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
        GameManager.GetInstance().addAction();

        if (comentarioTexto.text == "Me gustan más las negras") GameManager.GetInstance().setBlacks(true);
        else GameManager.GetInstance().setBlacks(false);

        Debug.Log(GameManager.GetInstance().isBlack());
    }

    public void PostImage()
    {
        if (postImage != null)
            comentarioImage.sprite = postImage.sprite;
           
        DesactivarPaneles();
        GameManager.GetInstance().addMyLikes(likes);
        GameManager.GetInstance().addMyDislikes(dislikes);
        GameManager.GetInstance().addAction();
    }

    public void DesactivarPaneles()
    {
       if(post!=null) post.SetActive(true);

        if (post.GetComponent<UserMention>() != null)
            post.GetComponent<UserMention>().AddMention();

        panelOpciones.SetActive(false);
    }
}