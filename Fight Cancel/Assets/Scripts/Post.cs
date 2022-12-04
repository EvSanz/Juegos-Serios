using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Post : MonoBehaviour
{
    public GameObject post, panelOpciones; 
    public Text postTexto, comentarioTexto; 

    public void PostText()
    {
        comentarioTexto.text = postTexto.text;
        post.SetActive(true);
        panelOpciones.SetActive(false); 
    }
}
