using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : Player
{
    public float ActionTime { get; set; } = 1.50f;
    float actionTimer = 0;
    Pile pileSelection;

    int tokenCount = 0;
    


    public override void TakeTurn()
    {
        if (pileSelection == null)
        {
            
            int count = 0;
            do
            {
                count = Random.Range(0, Game.piles.Length);
                pileSelection = Game.piles[count];
                
            } while (pileSelection.tokens.Count > 0);
        }


        if (actionTimer >= ActionTime)
        {
            actionTimer -= ActionTime;

            if (tokenCount <= 0)
            {
                SelectToken();
                tokenCount++;
            } else if (tokenCount >= pileSelection.tokens.Count)
            {
                FinishTurn();
            } else
            {
                if (Random.value < .5f)
                {
                    SelectToken();

                }
                else
                {
                    FinishTurn();
                }
            }
        }
    }

    private void FinishTurn()
    {
        turnOver = true;
        tokenCount = 0;
        pileSelection = null;
    }

    private void SelectToken()
    {
        int tokenIndex = -1;
        do
        {
            tokenIndex = Random.Range(0, pileSelection.tokens.Count);
        } while (!pileSelection.tokens[tokenIndex].selected);
        pileSelection.tokens[tokenIndex].Select();
        tokenCount++;
    }
}
