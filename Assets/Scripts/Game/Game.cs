using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{


    static Game instance;
    public static Game Instance { get { return instance; } }

    public enum eState
    {
        Title,
        StartGame,
        Player1Turn,
        Player2Turn,
        EndGame
    }

    public eState State { get; set; } = eState.Title;
    public List<Token> selectedTokens { get; set; } = new List<Token>();

    public GameData gameData;
    public static Pile[] piles;
    public Player humanPrefab;
    public Player computerPrefab;
    public GameObject easyPrefab;
    public GameObject hardPrefab;
    public Transform pileLocator;

    Pile selectedPile;
    GameObject pileParent;
    Player player1;
    Player player2;
    //GameObject difficulty;


    public Pile selectablePile { get
        {
            foreach (Pile p in piles)
            {
                if (p.SelectedTokens > 0) return p;
            }
            return null;
        } /*set { selectablePile = value; }*/ }

    private void Awake()
    {
        instance = this;
    }

    public void Update()
    {
        switch (State)
        {
            case eState.Title:
                State = eState.StartGame;
                break;
            case eState.StartGame:
                player1 = Instantiate(humanPrefab);
                player1.name = gameData.player1Name;
                player2 = (gameData.IsAI) ? Instantiate(computerPrefab) : Instantiate(humanPrefab);
                player2.name = gameData.player2Name;
                pileParent = (gameData.Hard) ? Instantiate(hardPrefab) : Instantiate(easyPrefab);
                piles = pileParent.GetComponentsInChildren<Pile>();
                State = (Random.Range(0, 2) == 0) ? eState.Player1Turn : eState.Player2Turn;
                break;
            case eState.Player1Turn:
                player1.TakeTurn();
                if (CheckForWin())
                {
                    State = eState.EndGame;
                }

                if (player1.turnOver)
                {
                    State = eState.Player2Turn;
                    player1.turnOver = false;
                }
                break;
            case eState.Player2Turn:
                player2.TakeTurn();
                if (CheckForWin())
                {
                    State = eState.EndGame;
                }
                if (player2.turnOver)
                {
                    State = eState.Player1Turn;
                    player2.turnOver = false;
                }
                break;
            case eState.EndGame:
                break;
            default:
                break;
        }
    }

    public void OnEndTurn()
    {
        if (selectedTokens.Count == 0) return;
        RemoveTokens();
    }

    private void RemoveTokens()
    {
        foreach (Token t in selectedTokens)
        {
            t.parentPile.tokens.Remove(t);
            Destroy(t.gameObject);
        }
        selectedTokens.Clear();
        selectablePile.SelectedTokens = 0;
    }

    bool CheckForWin() 
    {
        int count = 0;
        foreach (Pile p in piles)
        {
            count += p.tokens.Count;
        }

        return (count == 1);
    }
}
