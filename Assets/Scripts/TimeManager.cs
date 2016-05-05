using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime;

    public Text theText;

    public GameObject gameOverScreen;

    public Player player;

    public string mainMenu;


	// Use this for initialization
	void Start ()
    {
        theText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {       
        startingTime -= Time.deltaTime;
        if(startingTime <= 0)
        {
            gameOverScreen.SetActive(true);
            player.gameObject.SetActive(false);
            //if (Input.anyKeyDown)
            //{
            //    Application.LoadLevel(mainMenu);
            //}

        }
        theText.text = "" + Mathf.Round(startingTime);
	}
    public void TryAgain()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void Quit()
    {
        Application.LoadLevel(mainMenu);
    }
}
