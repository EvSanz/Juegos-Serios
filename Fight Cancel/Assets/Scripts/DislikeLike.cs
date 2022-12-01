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
    bool canClick = true;

    public void DislikeLikeClick()
    {
        if (GameManager.GetInstance() != null)
        {
            if (canClick)
            {
                if (isDislike)
                {

                    GameManager.GetInstance().LessFollowers(followers);
                    dislike.sprite = dislikePressed;
                    canClick = false;
                }
                else if(!isDislike)
                {

                    GameManager.GetInstance().AddFollowers(followers);
                    like.sprite = likePressed;
                    canClick = false;

                }
  
            }
            
        }
    }
    public bool canPress()
    {

        return canClick;
    }
    public void setPress(bool press)
    {

        canClick = press; ;
    }

}

