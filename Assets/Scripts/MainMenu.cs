using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string startLevel;
    public string selectLevel;
    public string highScore;

    public void NewGame()
    {
        Application.LoadLevel(startLevel);
    }

    public void LevelSelect()
    {
        Application.LoadLevel(selectLevel);
    }

    public void HighScore()
    {
        Application.LoadLevel(highScore);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
