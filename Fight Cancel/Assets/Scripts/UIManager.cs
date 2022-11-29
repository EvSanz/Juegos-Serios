using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Text followers;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.GetInstance().UIManagerUpdate(this);
    }

    public void UpdateFollowers(int n)
    {
        followers.text = n.ToString() + " Seguidores";
    }
}
