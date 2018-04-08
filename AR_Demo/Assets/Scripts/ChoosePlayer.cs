using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoosePlayer : MonoBehaviour {

    public PlayerCharacterController redPC;
    public PlayerCharacterController bluePC;
    public Button redButton, blueButton;
    public GameObject gameOverPanel;

    private void Start()
    {
        redPC.enabled = false;
        bluePC.enabled = true;
        redButton.interactable = true;
        blueButton.interactable = false;
        gameOverPanel.SetActive(false);
    }


    public void PressRed()
    {
        redPC.enabled = true;
        bluePC.enabled = false;
        redButton.interactable = false;
        blueButton.interactable = true;
    }

    public void PressBlue()
    {
        redPC.enabled = false;
        bluePC.enabled = true;
        redButton.interactable = true;
        blueButton.interactable = false;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
