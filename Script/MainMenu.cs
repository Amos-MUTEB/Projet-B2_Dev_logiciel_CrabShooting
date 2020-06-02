using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text playerDisplay1;
    public Text playerDisplay2;


    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay1.text = "Player : " + DBManager.username;
            playerDisplay2.text = "Score : " + DBManager.score;
        }
    }
    public void GoToRegister()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToLogin()
    {
        SceneManager.LoadScene(2);
    }
   
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
