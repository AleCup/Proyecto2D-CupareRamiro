using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public GameManager1 gameManager;
    public TextMeshProUGUI score;
    void Update()
    {
        score.text = gameManager.TotalPoints.ToString();
        if(gameManager.TotalPoints >= 20)
        {
            FinishGame();
        }

    }

    public void FinishGame()
    {
        SceneManager.LoadScene("Victory");
    }
}
