using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectUserPhoto : MonoBehaviour
{
    // Start is called before the first frame update
    public void Select()
    {
        GameManager.GetInstance().setUserImage(this.gameObject.GetComponent<Image>().sprite);
    }
}
