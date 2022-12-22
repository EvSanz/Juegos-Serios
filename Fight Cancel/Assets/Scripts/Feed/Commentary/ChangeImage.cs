using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite white;
    public Sprite black;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameManager.GetInstance().isBlack());
        if (GameManager.GetInstance().isBlack())
            this.gameObject.GetComponent<Image>().sprite = black;
        else
            this.gameObject.GetComponent<Image>().sprite = white;
    }
}