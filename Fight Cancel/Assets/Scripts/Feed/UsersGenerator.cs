using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsersGenerator : MonoBehaviour
{
    public Sprite[] profileImages;
    public string[] usersNames = new string[] { "itsCarlos_17", "KatyVipo_4", "nuuurii_02", "juanant__", "user_123" };
    
    int index = 0;
    void Start()
    {
        index = Random.Range(0, profileImages.Length-1);
        Debug.Log("index Inicial: "+index);
    }
    public int getIndex()
    {
        return index;
    }
    public void addIndex()
    {
        index = (index + 1) % (profileImages.Length-1);
        //index++;
        //if (index > profileImages.Length - 1) index = 0;
        Debug.Log("index: " + index);
    }
}
