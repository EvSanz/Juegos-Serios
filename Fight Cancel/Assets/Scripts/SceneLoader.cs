using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public GameObject gameObject;
    public string sceneName;

    public int maxActions;

    public void ClickExit()
    {
        if (GameManager.GetInstance() != null)
        {
            LoadNextLevel();
            Debug.Log("Se cambia de escena");
        }
    }
    void LoadNextLevel()
    {
        GameManager.GetInstance().ChangeScene(sceneName);
    }

    private void Update()
    {
        if (GameManager.GetInstance().getCurrentActions() == maxActions)
        {
            gameObject.SetActive(true);
        }
    }
}
