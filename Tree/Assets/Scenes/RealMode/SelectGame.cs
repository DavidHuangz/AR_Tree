using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene("NewGame");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LoadGame");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}