using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Player player;
    public GameObject victoryScreen;
    public string nextLevel;
    public string mainMenu;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Player>();

        score = 0;

    }

    void Update()
    {
        if (score == 4)
        {
            victoryScreen.SetActive(true);
            player.gameObject.SetActive(false);
            //if(Input.anyKeyDown)
            //{
            //    Application.LoadLevel(nextLevel);
            //}
        }

        text.text = "" + score;
       
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
    public void TryAgain()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Quit()
    {
        Application.LoadLevel(mainMenu);
    }
    public void NextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
   



}
