using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManagements : MonoBehaviour
{
    public void PlayButton(string gamePlaying)
    {
        SceneManager.LoadScene(gamePlaying);
    }
    public void ContinueButton(string playing)
    {
        SceneManager.LoadScene(playing);
    }
    public void SettingButton(string gameSetting)
    {
        SceneManager.LoadScene(gameSetting);
    }
    public void BackButton(string backButton)
    {
        SceneManager.LoadScene(backButton);
    }

    public void GoToMainConfig()
    {
        SceneManager.LoadScene(5);
    }
    public void GoToConfigSpeed()
    {
        SceneManager.LoadScene(6);
    }
    public void GoToConfigDirection()
    {
        SceneManager.LoadScene(7);
    }
    public void BackToMainConfig()
    {
        SceneManager.LoadScene(5);
    }
    public void BackToGameAnnouncement()
    {
        SceneManager.LoadScene(3);
    }

}
