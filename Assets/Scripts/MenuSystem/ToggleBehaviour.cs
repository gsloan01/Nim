using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBehaviour : MonoBehaviour
{
    public Toggle otherToggle;
    public Toggle currentToggle;
    public bool value;

    public Button startButton;

    public GameData currentGame;

    public bool isDifficultySelection;

    public void IsToggled()
    {
        if (currentToggle == true)
        {
            if(otherToggle != null)
            {
                otherToggle.GetComponent<Toggle>().isOn = false;
            }
        }

        if (isDifficultySelection)
        {
            currentGame.difficultySelected = true;
            currentGame.Hard = true;
        }
        else
        {
            currentGame.modeSelected = true;
            currentGame.IsAI = value;
        }




    }

    private void Update()
    {
/*        if (currentToggle.isOn == false || otherToggle.isOn == false)
        {
            //startButton.interactable = false;
        }
        else if (currentToggle.isOn == true || otherToggle.isOn == true)
        {
            startButton.interactable = false;
        }
        else
        {
            //startButton.interactable = true;
        }*/

    }

}
