using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private UIManager UIManager;
    //public static GameManager instance = null;

    int seguidores = 200;
    int post = 0;
    float likes = 1, dislikes = 1;

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
    }

    private void Update()
    {
        //LessFollowers(1);
    }

    public void LessFollowers(int lostFollowers)
    {
        seguidores -= lostFollowers;

        if (seguidores <= 0)
            seguidores = 0;
    }

    public void AddFollowers(int newFollowers)
    {
        seguidores += newFollowers;
    }

    public bool HowManyPost()
    {
        return post < 1;
    }

    public void AddPost()
    {
        post++;
    }

    public void UIManagerUpdate(UIManager uim)
    {
        UIManager = uim;
        UIManager.UpdateFollowers(seguidores);
        UIManager.UpdateSlider(likes, dislikes);
    }

    public static GameManager GetInstance()
    {
        return instance;
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}