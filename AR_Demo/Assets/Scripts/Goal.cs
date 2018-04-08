using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public int characterCount = 0;
    public int maxCharacters = 2;
    public ChoosePlayer choosePlayer;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            characterCount++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            characterCount--;
        }
    }

    private void LateUpdate()
    {
        if(characterCount >= maxCharacters)
        {
            Time.timeScale = 0;
            
            choosePlayer.GameOver();
        }
    }
}
