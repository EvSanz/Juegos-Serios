using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleLikes : MonoBehaviour
{
    [SerializeField]
    GameObject like;

    [SerializeField]
    GameObject dislike;

    DislikeLike likeComp;
    DislikeLike dislikeComp;

    [SerializeField]
    bool isCelebrity;

    bool dia1;
    GameManager gm;

    void Start()
    {
        likeComp = like.GetComponentInChildren<DislikeLike>();
        dislikeComp = dislike.GetComponentInChildren<DislikeLike>();
        gm = GameManager.GetInstance();

        dia1 = SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Dia1");

        if (dia1 && isCelebrity) //si es el dia 1 y es una celebrity no puede le puede dar dislike
        {
            dislikeComp.setPress(false); 
        }
    }

    private void Update()
    {
        if (dia1 && isCelebrity) 
        {
            if (!likeComp.canPress())
            {
                gm.SetLikeCelebrity();
            }
        }

        else
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
}
