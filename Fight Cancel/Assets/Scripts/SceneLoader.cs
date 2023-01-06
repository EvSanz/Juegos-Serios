using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public GameObject gameObject, playerTalk;
    public string sceneName;

    public int maxActions;

    private bool exitActive = false; 

    public void ClickExit()
    {
        if (GameManager.GetInstance() != null)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
       
        GameManager.GetInstance().ChangeScene(sceneName);
    }

    public void QuitGame()
    {

        Application.Quit(); //quita el juego en la build pero no se ve en el editor
    }

    private void Update()
    {
          if (GameManager.GetInstance().getCurrentActions() >= maxActions && !exitActive)
            {
                if (playerTalk != null)
                    playerTalk.SetActive(true);

                gameObject.SetActive(true);

                exitActive = true;
            }
        
       
        //Debug.Log("Acciones actuales: "+GameManager.GetInstance().getCurrentActions());
    }
}
