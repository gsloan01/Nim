using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject optionsScreen;
    public GameObject pauseScreen;
    public GameObject selectScreen;
    public GameObject gameOptionsScreen;
    public GameObject gameOverScreen;

    public GameObject menuCamera;
    public GameObject gameCamera;

    public GameObject player1Panel;
    public GameObject player2Panel;

    public GameObject player1Input;
    public GameObject player2Input;

    public GameData currentGame;
    public TextMesh ah;

    string player1name;
    string player2name;

    //public Transition transition;

    public AudioMixer audioMixer;

    public int highScore = 0;

    bool isPaused = false;
    float timeScale;

    static GameController instance = null;
    public static GameController Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameReset();
        //titleScreen.SetActive(true);



    }


    public void gameReset()
    {
        currentGame.IsAI = false;
        currentGame.Hard = false;
        currentGame.modeSelected = false;
        currentGame.difficultySelected = false;
        currentGame.gameOver = false;
        currentGame.player1Name = null;
        currentGame.player2Name = null;
    }

    public void SetHighScore(int score)
    {
        highScore = score;
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public void OnLoadGameScene(string scene)
    {
        
        player1name = player1Input.GetComponent<TMP_InputField>().text;
        currentGame.player1Name = player1name;
        if (!currentGame.IsAI)
        {
            player2name = player2Input.GetComponent<TMP_InputField>().text;
            currentGame.player2Name = player2name;
        }

        titleScreen.SetActive(false);
        selectScreen.SetActive(false);
        gameOptionsScreen.SetActive(false);

        menuCamera.SetActive(false);
        gameCamera.SetActive(true);

        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
        //transition.StartTransition(Color.black, 2);
        //SceneManager.LoadScene(scene);



        gameOptionsScreen.SetActive(false);
    }


    public void OnLoadMenuScene(string sceneName)
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        StartCoroutine(LoadMenuScene(sceneName));
    }

    IEnumerator LoadMenuScene(string sceneName)
    {
        //transition.StartTransition(Color.black, 1);

        //while (!transition.IsDone) { yield return null; }

        titleScreen.SetActive(true);
        SceneManager.LoadScene(sceneName);

        yield return null;
    }

    public void OnTitleScreen()
    {
        gameReset();
        titleScreen.SetActive(true);
        optionsScreen.SetActive(false);
        selectScreen.SetActive(false);
        gameOptionsScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        

    }

    public void OnOptionsScreen()
    {
        titleScreen.SetActive(false);
        optionsScreen.SetActive(true);
    }

    public void OnPauseScreen()
    {
        if(isPaused)
        {
            isPaused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = timeScale;

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            isPaused = true;
            pauseScreen.SetActive(true);
            timeScale = Time.timeScale;
            Time.timeScale = 0;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void OnSelectScreen()
    {
        selectScreen.SetActive(true);

        if(currentGame.IsAI)
        {
            player2Panel.SetActive(false);
            currentGame.player2Name = "Pesky Dwarf";

        }

        titleScreen.SetActive(false);
        optionsScreen.SetActive(false);
        gameOptionsScreen.SetActive(false);
    }

    public void OnGameOptionsScreen()
    {
        
        selectScreen.SetActive(false);
        titleScreen.SetActive(false);
        optionsScreen.SetActive(false);
        gameOptionsScreen.SetActive(true);

        gameReset();
        

    }

    public void OnGameOverScreen()
    {
        if (currentGame.gameOver == true)
        {
            gameOverScreen.SetActive(true);
            gameCamera.SetActive(false);
            menuCamera.SetActive(true);
        }
        
    }



    public void OnPause()
    {
        OnPauseScreen();
    }

    public void OnMasterVolume(float level)
    {
        audioMixer.SetFloat("MasterVolume", level);
    }

    public void OnMusicVolume(float level)
    {
        audioMixer.SetFloat("MusicVolume", level);
    }

    public void OnSFXVolume(float level)
    {
        audioMixer.SetFloat("SFXVolume", level);
    }

    public void Update()
    {
        OnGameOverScreen();
    }
}
