using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameMusicPlayer : MonoBehaviour
{
    public List<AudioClip> tracks = new List<AudioClip>();
    public TMP_Text songNameDisplay;

    AudioSource audioSource;
    float timer = 0;
    int trackIndex;

    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        trackIndex = Random.Range(0, tracks.Count-1);
        audioSource.clip = tracks[trackIndex];
        audioSource.Play();
        songNameDisplay.text = "Currently Playing : \n" + tracks[trackIndex].name;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= tracks[trackIndex].length - 0.5f)
        {
            timer = 0;
            trackIndex = Random.Range(0, tracks.Count - 1);
            audioSource.clip = tracks[trackIndex];
            audioSource.Play();

            songNameDisplay.text = "Currently Playing : \n" + tracks[trackIndex].name;


        }
    }
}
