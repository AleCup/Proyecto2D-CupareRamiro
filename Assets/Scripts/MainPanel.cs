using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeMaster;
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject optionsPanel;

    public void PlayLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void openPanel(GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);

        panel.SetActive(true);
    }

}
