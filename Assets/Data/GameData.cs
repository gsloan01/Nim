using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game", menuName = "Data/Game")]
public class GameData : ScriptableObject
{
    public string player1Name;
    public string player2Name;
    public bool IsAI;
    public bool Easy;
    public bool Hard;
    
}
