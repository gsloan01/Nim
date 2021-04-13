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
        if (true)
        {
            turnOver = true;
        }
    }
}
