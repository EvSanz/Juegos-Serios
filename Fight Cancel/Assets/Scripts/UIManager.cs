using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Text followers, hora, fecha;
    [SerializeField]
    Slider slider;
    DateTime DateFetcher;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = 100;
        slider.minValue = 0;
        slider.interactable = false;
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
    public void UpdateSlider(float likes, float dislikes)
    {
        float total = likes + dislikes;
        slider.value = (likes / total) * 100;
    }

    private void updateDate()
    {
        //ESCRIBIR HORA
        if (DateFetcher.Hour < 10 && DateFetcher.Minute < 10)
            hora.text = "0" + DateFetcher.Hour.ToString() + " : 0" + DateFetcher.Minute.ToString();
        else if (DateFetcher.Hour < 10)
            hora.text = "0" + DateFetcher.Hour.ToString() + " : " + DateFetcher.Minute.ToString();
        else if (DateFetcher.Minute < 10)
            hora.text = DateFetcher.Hour.ToString() + " : 0" + DateFetcher.Minute.ToString();
        else
            hora.text = DateFetcher.Hour.ToString() + " : " + DateFetcher.Minute.ToString();

        //ESCRIBIR FECHA
        int day = GameManager.GetInstance().getDay();
        if (day < 10 && DateFetcher.Month < 10)
            fecha.text = "0" + day.ToString() + " / 0" + DateFetcher.Month.ToString() + " / " + DateFetcher.Year.ToString();
        else if (day < 10)
            fecha.text = "0" + day.ToString() + " / " + DateFetcher.Month.ToString() + " / " + DateFetcher.Year.ToString();
        else if (DateFetcher.Month < 10)
            fecha.text = day.ToString() + " / 0" + DateFetcher.Month.ToString() + " / " + DateFetcher.Year.ToString();
        else
            fecha.text = day.ToString() + " / " + DateFetcher.Month.ToString() + " / " + DateFetcher.Year.ToString();
    }
}