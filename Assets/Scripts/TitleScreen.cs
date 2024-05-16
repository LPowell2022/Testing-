using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public void Arcade()
    {
        SceneManager.LoadScene(10);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void CampaignMode()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(4);
    }

    public void GameModes()
    {
        SceneManager.LoadScene(5);
    }

    public void BlockBreaker()
    {
        SceneManager.LoadScene(6);
    }

    public void TimeTravelMenu()
    {
        SceneManager.LoadScene(7);
    }

    public void PS1Outdoors()
    {
        SceneManager.LoadScene(8);
    }

    public void MultiBallMode()
    {
        SceneManager.LoadScene(9);
    }
    public void Page2()
    {
        SceneManager.LoadScene(11);
    }
    public void BossMode1P()
    {
        SceneManager.LoadScene(12);
    }
    public void BossMode2P()
    {
        SceneManager.LoadScene(13);
    }
    public void MonsterMode1P()
    {
        SceneManager.LoadScene(14);
    }
    public void MonsterMode2P()
    {
        SceneManager.LoadScene(15);
    }
    public void MultiPaddleMode ()
    {
        SceneManager.LoadScene(16);
    }
    public void Almanac()
    {
        SceneManager.LoadScene(17);
    }
}
