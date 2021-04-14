using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Player
{
    public override void TakeTurn()
    {
        
    }

    public void OnEndTurn()
    {
        if (Game.Instance.selectedTokens.Count > 0)
        {
            turnOver = true;
        }
    }
}
