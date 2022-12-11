using UnityEngine;

public class UsersGenerator : MonoBehaviour
{
    public Sprite[] profileImages;
    public string[] usersNames = new string[] { "itsCarlos_17", "KatyVipo_4", "nuuurii_02", "juanant__", "user_123" };
    public GameObject[] users;
    
    int index = 0;
    void Start()
    {
        index = Random.Range(0, profileImages.Length-1);

        for (int i = 0; i < users.Length; i++)
        {
            users[i].GetComponent<SelectUser>().setImage(profileImages[index]);
            users[i].GetComponent<SelectUser>().setName(usersNames[index]);
            addIndex();
        }
    }
    public void addIndex()
    {
        index = (index + 1) % profileImages.Length;
    }
}