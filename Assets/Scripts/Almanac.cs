using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Almanac : MonoBehaviour
{

    public GameObject instructionsText;
    public GameObject gameModesText;
    public GameObject arcadeText;
    public GameObject historyOfTennisText;
    public GameObject historyOfTennisGamesText;
    public GameObject upcomingFeaturesText;
    public GameObject teamText;

    private void Start()
        {
            
            Begin();
        }

    public void Begin()
    {
        instructionsText.SetActive(false);
        gameModesText.SetActive(false);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(false);
    }

    public void Instructions()
    {
        instructionsText.SetActive(true);
    }
    public void GameModes()
    {
        gameModesText.SetActive(true);
    }
    public void ArcadeText()
    {
        arcadeText.SetActive(true);
    }
    public void HistoryOfTennis()
    {
        historyOfTennisText.SetActive(true);
    }
    public void HistoryOfTennisGames()
    {
        historyOfTennisGamesText.SetActive(true);
    }
    public void Team()
    {
        teamText.SetActive(true);
    }
    public void UpcomingFeatures()
    {
        upcomingFeaturesText.SetActive(true);
    }
}
