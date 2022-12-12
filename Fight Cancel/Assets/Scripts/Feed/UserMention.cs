using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UserMention : MonoBehaviour
{
    public Text mention;
    public Text userName;

    public void AddMention()
    {
        mention.text = "@" + userName.text;
    }
}
