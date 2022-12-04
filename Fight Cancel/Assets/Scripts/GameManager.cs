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
    int contador = 0; 
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
        contador = seguidores; 
    }

    private void Update()
    {
        //LessFollowers(1);
    }

    public void LessFollowers(int lostFollowers)
    {
        contador -= lostFollowers;

        if (contador <= 0)
            contador = 0;
    }

    public void AddFollowers(int newFollowers)
    {
        contador += newFollowers;
    }

    public int GetPost() { return post; }

    public void AddPost() { post++; }

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
        post = 0; 
        seguidores = contador; 

        SceneManager.LoadScene(sceneName);
    }
}