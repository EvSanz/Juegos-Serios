using UnityEngine;
using UnityEngine.UI;

public class SelectUser : MonoBehaviour
{
    public Text userName;
    public Image profilePhoto;
   
    public void setImage(Sprite img)
    {
        profilePhoto.sprite = img;
    }

    public void setName(string nme)
    {
        userName.text = nme;
    }
}
