using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public string sceneName;

    public int maxActions; 

    //public void ClickExit()
    //{
    //    if (GameManager.GetInstance() != null)
    //    {

    //        if (GameManager.GetInstance().getCurrentActions() == maxActions /*&& GameManager.GetInstance().GetLikeCelebrity()*/)
    //        {
    //            LoadNextLevel();
    //            Debug.Log("Se cambia de escena");

    //        }
    //    }
    //}
    void LoadNextLevel()
    {
        GameManager.GetInstance().ChangeScene(sceneName);
    }

    private void Update()
    {
        if (GameManager.GetInstance().getCurrentActions() == maxActions)
        {
            System.Threading.Thread.Sleep(1000);
            LoadNextLevel();
            Debug.Log("Se cambia de escena");
        }
    }
}
