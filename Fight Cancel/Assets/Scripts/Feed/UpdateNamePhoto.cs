using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UpdateNamePhoto : MonoBehaviour
{
    public Text username;
    //public Image profilePic; 

    void Update()
    {
        if (GameManager.GetInstance().GivePlayerName() != username.text)
            username.text = GameManager.GetInstance().GivePlayerName();

        //if (GameManager.GetInstance().GivePlayerPhoto() != profilePic.sprite)
        //    profilePic.sprite = GameManager.GetInstance().GivePlayerName();
    }
}
