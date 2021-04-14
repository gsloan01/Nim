using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMusicPlayer : MonoBehaviour
{
    public List<AudioClip> tracks = new List<AudioClip>();

    AudioSource audioSource;
    float timer = 0;
    int trackIndex;
    Random rand = new Random();

    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();

        trackIndex = Random.Range(0, tracks.Count-1);
        audioSource.clip = tracks[trackIndex];
        audioSource.Play();
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

        }
    }
}
