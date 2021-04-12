using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    //Controls
    public static bool CONT_Select = false;

    public static GameControls controls;


    public GameObject pileParent;
    Pile[] piles;
    Pile selectedPile;

    public List<Token> selectedTokens { get; set; } = new List<Token>();

    static Game instance;
    public static Game Instance { get { return instance; } }

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

    // Start is called before the first frame update
    void Start()
    {
        piles = pileParent.GetComponentsInChildren<Pile>();
        controls = new GameControls();
        

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    EndTurn();
        //    bool win = CheckForWin();
        //    Debug.Log(win);
        //}
    }

    bool CheckForWin() 
    {
        int count = 0;
        foreach (Pile p in piles)
        {
            count += p.tokens.Count;
        }

        return (count <= 1);
    }
}
