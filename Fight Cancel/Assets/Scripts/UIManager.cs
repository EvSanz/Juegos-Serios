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

    bool dayChanged;

    // Start is called before the first frame update
    void Start()
    {
        if (slider != null)
        {
            slider.maxValue = 100;
            slider.minValue = 0;
            slider.interactable = false;
        }
        dayChanged = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (dayChanged)
        {
            GameManager.GetInstance().UIManagerUpdate(this);
            dayChanged = false;
        }
        
        DateFetcher = DateTime.Now;
        updateDate();
    }

    public void UpdateFollowers(int n)
    {
        if (followers != null)
            followers.text = n.ToString() + " Seguidores";
    }
    public void UpdateSlider(float likes, float dislikes)
    {
        float total = likes + dislikes;
        if (slider != null)
            slider.value = (likes / total) * 100;
    }

    private void updateDate()
    {
        if (hora != null)
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
        }
        if (fecha != null) 
        {
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
    public void changeDay(bool change)
    {
        dayChanged = change;
    }
}