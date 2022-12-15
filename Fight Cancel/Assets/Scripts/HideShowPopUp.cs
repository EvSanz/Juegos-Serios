using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HideShowPopUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int numNotification;
    [SerializeField]
    Text notifText;
    public bool especial;

    void Start()
    {
        //this.notifText.text = "Tienes " + numNotification + " notificaciones";

        //if (GameManager.GetInstance() != null)
        //{
        //    if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Dia2"))
        //    {
        //        showPopUp();
        //    }
        //    else
        //    {
        //        hidePopUp();
        //    }
        //}
        showPopUp();
    }

    public void hidePopUp()
    {
        if (especial) GameManager.GetInstance().addAction();
        this.gameObject.SetActive(false);
    }
    public void showPopUp()
    {
        this.gameObject.SetActive(true);
    }
}
