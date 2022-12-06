using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public string sceneName;

    public int maxActions; 

    public void ClickExit()
    {
        if (GameManager.GetInstance() != null)
        {

            if (GameManager.GetInstance().GetPost() == maxActions && GameManager.GetInstance().GetLikeCelebrity())
            {
                LoadNextLevel();
                Debug.Log("Se cambia de escena");

            }
        }
    }
    void LoadNextLevel()
    {
        GameManager.GetInstance().ChangeScene(sceneName);
    }
}
