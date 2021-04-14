using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game", menuName = "Data/Game")]
public class GameData : ScriptableObject
{
    public string player1Name;
    public string player2Name;
    public bool IsAI;
    public bool Hard;

    public bool difficultySelected;
    public bool modeSelected;
    public bool gameOver;

    public  bool gameCanStart { get { return (difficultySelected && modeSelected); } }

}
