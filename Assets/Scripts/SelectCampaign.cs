using UnityEngine;
using System.Collections;

public class SelectCampaign : MonoBehaviour {

    public string happyCastle;
    public string mainMenu;

    // Use this for initialization
    public void HappyCastle()
    {
        Application.LoadLevel(happyCastle);
    }
    public void MainMenu()
    {
        Application.LoadLevel(mainMenu);
    }
}
