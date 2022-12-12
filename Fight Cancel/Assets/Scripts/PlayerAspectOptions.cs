using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerAspectOptions : MonoBehaviour
{
    public GameObject panel, panelTexto, panelImagen;
    public Text playerName, choosenName;
    public Image player, choosenImage;
    public bool texto;

    public void OpenPanel()
    {
        panel.SetActive(true); 
    }

    public void ChooseOption()
    {
        if (texto)
            panelTexto.SetActive(true);
        else
            panelImagen.SetActive(true);

        panel.SetActive(false);
    }

    public void ChooseImageProfile()
    {
        player.sprite = choosenImage.sprite;
        //GameManager.GetInstance().SavePlayerImage(player);
        panelImagen.SetActive(false);
    }

    public void ChooseTextProfile()
    {
        playerName.text = choosenName.text;
        GameManager.GetInstance().SavePlayerName(playerName.text); 
        panelTexto.SetActive(false);
    }

    public void ClosePanel()
    {
        if (panel != null)
            panel.SetActive(false);

        if (panelTexto != null)
            panelTexto.SetActive(false);

        if (panelImagen != null)
            panelImagen.SetActive(false);
    }
}
