using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Text followers, hora, fecha;

    DateTime DateFetcher;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.GetInstance().UIManagerUpdate(this);
        DateFetcher = DateTime.Now;
        updateDate();
    }

    public void UpdateFollowers(int n)
    {
        followers.text = n.ToString() + " Seguidores";
    }

    private void updateDate()
    {
        hora.text = DateFetcher.Hour.ToString() + " : " + DateFetcher.Minute.ToString();
        fecha.text = DateFetcher.Day.ToString() + " / " + DateFetcher.Month.ToString() + " / " + DateFetcher.Year.ToString();
    }
}
