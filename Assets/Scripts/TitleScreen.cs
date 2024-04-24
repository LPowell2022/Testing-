using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public void Arcade()
    {
        SceneManager.LoadScene(0);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void CampaignMode()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(3);
    }

    public void GameModes()
    {
        SceneManager.LoadScene(4);
    }

    public void BlockBreaker()
    {
        SceneManager.LoadScene(5);
    }

    public void TimeTravelMenu()
    {
        SceneManager.LoadScene(6);
    }

    public void PS1Outdoors()
    {
        SceneManager.LoadScene(7);
    }
}
