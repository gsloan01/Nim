using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class GameSession : MonoBehaviour
{
    public enum eState
    {
        StartSession,
        Session,
        EndSession,
        GameOver
    }

    public eState State { get; set; } = eState.StartSession;
    public float Score { get; set; } = 0;

    static GameSession instance;
    public static GameSession Instance { get { return instance; } }

    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI timerUI;
    public GameObject startScreen;

    //private float highScore = 0;
    private float timer = 0.0f;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        EventManager.Instance.Subscribe("PlayerDead", OnPlayerDead);
    }

    void Update()
    {
        switch (State)
        {
            case eState.StartSession:
                Debug.Log("StartSession");
                Score = 0;
                EventManager.Instance.TriggerEvent("StartSession");
                GameController.Instance.transition.StartTransition(Color.clear, 1);
                State = eState.Session;
                break;
            case eState.Session:
                Debug.Log("Session");
                break;
            case eState.EndSession:
                Debug.Log("EndSession");
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    GameObject gameObject = GameObject.FindGameObjectWithTag("PlayerPackage");
                    State = eState.StartSession;
                    Destroy(gameObject);

                    
                }
                break;
            case eState.GameOver:
                break;
            default:
                break;
        }
    }

    public void AddPoints(float points)
    {
        Score += points;
        scoreUI.text = string.Format("{0:D4}", (int)Score);
    }

    public void OnPlayerDead()
    {
        GameController.Instance.transition.StartTransition(Color.black, 1);
        timer = 2.0f;
        State = eState.EndSession;
    }
}
