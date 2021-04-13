using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBehaviour : MonoBehaviour
{
    public Toggle otherToggle;
    public Toggle currentToggle;

    public void IsToggled()
    {
        if (currentToggle == true)
        {
            otherToggle.GetComponent<Toggle>().isOn = false;
        }
        else
        {
            otherToggle.GetComponent<Toggle>().isOn = true;
        }

    }

}
