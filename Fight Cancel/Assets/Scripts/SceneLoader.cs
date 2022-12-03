using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1.0f;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadLevel();
        }
    }
    public void LoadLevel()
    {
        //StartCoroutine(LoadNextLevel());
        LoadNextLevel();
    }
    /*IEnumerator*/ void LoadNextLevel()
    {
        //transition.SetTrigger("Start");
        //yield return new WaitForSeconds(transitionTime);
        GameManager.GetInstance().ChangeScene(sceneName);
    }
   
}
