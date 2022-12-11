using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectUser : MonoBehaviour
{
    public Text userName;
    public Image profilePhoto;
    void Start()
    {
        UsersGenerator u = this.gameObject.GetComponentInParent<UsersGenerator>();
        profilePhoto.sprite = u.profileImages[u.getIndex()];
        userName.text = u.usersNames[u.getIndex()];
        u.addIndex();
    }
}
