using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseFollowers : MonoBehaviour
{
    public int nFollowers;
    // Start is called before the first frame update
    public void decreaseFollowers()
    {
        GameManager.GetInstance().LessFollowers(nFollowers);
    }
}
