using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public string name;
    public bool turnOver = false;

    public abstract void TakeTurn();
}
