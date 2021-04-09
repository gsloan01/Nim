using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    public List<Token> tokens = new List<Token>();

    public int SelectedTokens { get; set; }



    // Start is called before the first frame update
    void Start()
    {
        Token[] newTokens = GetComponentsInChildren<Token>();
        
        for (int i = 0; i < newTokens.Length; i++)
        {
            tokens.Add(newTokens[i]);
        }
    }

    

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
