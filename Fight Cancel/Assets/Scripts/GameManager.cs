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
    bool GameIsPaused = false, ChangedScene=false;

    int seguidores = 105786;
    int contador = 0; 
    int post = 0, day=10;
    bool likedCelebrity = false, blacks=false;
    int currentActions = 0;

    float likes = 1, dislikes = 1;

    string username;
    Sprite userPhoto = null;
    // Image userPhoto; 

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
        GameIsPaused = false;
    }
    public void restartGame()
    {
        seguidores = 105786;
        contador = seguidores;
        post = 0;
        day = 10;
        likedCelebrity = false;
        blacks = false;
        currentActions = 0;
        likes = 1;
        dislikes = 1;
        GameIsPaused = false;
        Time.timeScale = 1f;
    }
    private void Update()
    {
        //LessFollowers(1);
    }

    public string GivePlayerName()
    {
        return username; 
    }

    public void SavePlayerName(string player)
    {
        username = player; 
    }

    public void LessFollowers(int lostFollowers)
    {
        contador -= lostFollowers;
        //seguidores -= lostFollowers;

        if (contador <= 0)
            contador = 0;
    }

    public void AddFollowers(int newFollowers)
    {
        contador += newFollowers;
        //seguidores += newFollowers;
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
        if (sceneName == "Menu")
        {
            restartGame();
        }
        else
        {
            post = 0;
            seguidores = contador;
            day++;
            //likedCelebrity = false;
            currentActions = 0;
            
        }
        GameIsPaused = false;
        SceneManager.LoadScene(sceneName);
    }
    public void SetLikeCelebrity()
    {
        likedCelebrity = true;
       
    }
    public bool GetLikeCelebrity()
    {
        return likedCelebrity;
    }
    public void addMyLikes(int n)
    {
        likes += n;
    }
    public void addMyDislikes(int n)
    {
        dislikes += n;
    }
    public void addAction()
    {
        currentActions++;
        Debug.Log("+1 Accion");
    }

    public int getCurrentActions()
    {
        return currentActions;
    }

    public void setBlacks(bool b)
    {
        blacks = b;
    }
    public bool isBlack()
    {
        return blacks;
    }
    public int getDay()
    {
        return day;
    }

    public void setUserImage(Sprite s)
    {
        userPhoto = s;
    }

    public Sprite getUserImgae()
    {
        return userPhoto;
    }
 
    public bool GetPaused()
    {
        return GameIsPaused;
    }
    public void setPaused(bool pausedState)
    {
        GameIsPaused = pausedState;
    }
    
}