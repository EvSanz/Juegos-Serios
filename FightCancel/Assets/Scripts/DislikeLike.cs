using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DislikeLike : MonoBehaviour
{
    public bool dislike;
    public int followers; 

    void OnMouseDown()
    {
        if (GameManager.instance != null)
        {
            if (dislike)
                GameManager.instance.LessFollowers(followers);
            else
                GameManager.instance.AddFollowers(followers); 
        }
    }
}
