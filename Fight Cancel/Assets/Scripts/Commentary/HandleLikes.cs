using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleLikes : MonoBehaviour
{
    [SerializeField]
    GameObject like;

    [SerializeField]
    GameObject dislike;

    DislikeLike likeComp;
    DislikeLike dislikeComp;

    bool canLike;
    bool canDislike;
    void Start()
    {
        likeComp = like.GetComponentInChildren<DislikeLike>();
        dislikeComp = dislike.GetComponentInChildren<DislikeLike>();
   
    }
    private void Update()
    {
        if (!likeComp.canPress())
        {
            dislikeComp.setPress(false);
        }
        else if (!dislikeComp.canPress())
        {
            likeComp.setPress(false);

        }
    }
}
