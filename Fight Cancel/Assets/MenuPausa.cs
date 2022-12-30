using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenuUI;

    GameManager gm;
    private void Start()
    {
        if (GameManager.GetInstance() != null)
        {
            gm = GameManager.GetInstance();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gm.GetPaused())
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        
    }
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gm.setPaused(false);

    }
    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gm.setPaused(true);
    }
    
}
