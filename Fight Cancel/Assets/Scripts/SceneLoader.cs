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
    public void LoadNextLevel()
    {
        GameManager.GetInstance().ChangeScene(sceneName);
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false; //para el juego en el editor
        Application.Quit(); //quita el juego en la build pero no se ve en el editor
    }
    private void Update()
    {
        
        if (GameManager.GetInstance().getCurrentActions() >= maxActions)
        {
            gameObject.SetActive(true);
        }
    }
}
