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
        gameModesText.SetActive(false);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(false);
    }
    public void GameModes()
    {
        gameModesText.SetActive(true);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(false);
        instructionsText.SetActive(false);
    }
    public void ArcadeText()
    {
        instructionsText.SetActive(false);
        gameModesText.SetActive(false);
        arcadeText.SetActive(true);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(false);
    }
    public void HistoryOfTennis()
    {
        instructionsText.SetActive(false);
        gameModesText.SetActive(false);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(true);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(false);
    }
    public void HistoryOfTennisGames()
    {
        instructionsText.SetActive(false);
        gameModesText.SetActive(false);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(true);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(false);
    }
    public void Team()
    {
        instructionsText.SetActive(false);
        gameModesText.SetActive(false);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(true);
        upcomingFeaturesText.SetActive(false);
    }
    public void UpcomingFeatures()
    {
        instructionsText.SetActive(false);
        gameModesText.SetActive(false);
        arcadeText.SetActive(false);
        historyOfTennisGamesText.SetActive(false);
        historyOfTennisText.SetActive(false);
        teamText.SetActive(false);
        upcomingFeaturesText.SetActive(true);
    }
}
