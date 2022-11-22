using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publish : MonoBehaviour
{
    public GameObject foto;
    public GameObject publicaciones;

    public Sprite post;
    public int lostFollowers; 

    SpriteRenderer fotoRenderer; 

    void Start()
    {
        fotoRenderer = foto.GetComponent<SpriteRenderer>(); 
        foto.SetActive(false); 
    }

    void OnMouseDown()
    {
            publicaciones.SetActive(false);

        if (GameManager.instance != null)
                GameManager.instance.LessFollowers(lostFollowers);

        fotoRenderer.sprite = post;
        foto.SetActive(true); 
    }
}
