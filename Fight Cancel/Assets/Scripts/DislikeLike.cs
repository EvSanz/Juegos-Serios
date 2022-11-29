using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DislikeLike : MonoBehaviour
{
    public bool isDislike;
    public int followers;
    [SerializeField]
    Image like, dislike;
    [SerializeField]
    Sprite likePressed, dislikePressed;
    //void OnMouseDown()
    //{
    //    Debug.Log("lkjhgfd");
    //    if (GameManager.GetInstance() != null)
    //    {
    //        if (dislike)
    //            GameManager.GetInstance().LessFollowers(followers);
    //        else
    //            GameManager.GetInstance().AddFollowers(followers);
    //    }
    //}

    public void DislikeLikeClick()
    {
        if (GameManager.GetInstance() != null)
        {
            if (isDislike)
            {
                GameManager.GetInstance().LessFollowers(followers);
                dislike.sprite = dislikePressed;
            }
            else
            {
                GameManager.GetInstance().AddFollowers(followers);
                like.sprite = likePressed;
            }
        }
    }
}
