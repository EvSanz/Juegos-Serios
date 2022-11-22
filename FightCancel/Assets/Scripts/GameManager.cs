using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public Text followers;

    int seguidores = 200;
    int post = 0; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
            Destroy(this.gameObject);
    }

    void Start()
    {
        followers.text = seguidores.ToString(); 
    }

    public void LessFollowers(int lostFollowers)
    {
        seguidores -= lostFollowers;

        if (seguidores >= 0)
            followers.text = seguidores.ToString();
        else
            followers.text = "0"; 
    }

    public void AddFollowers(int newFollowers)
    {
        seguidores += newFollowers;
        followers.text = seguidores.ToString();
    }

    public bool HowManyPost()
    {
        return post < 1; 
    }

    public void AddPost()
    {
        post++; 
    }
}
