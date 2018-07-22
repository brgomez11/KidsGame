using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour {
    // Reference to Audio Source component
    private AudioSource audioSrc;
    // Music volume variable that will be modified
    // by dragging slider knob
    private float musicVolume = 1f;

    // Use this for initialization
    void Start () {
        // Assign Audio Source component to control it
        audioSrc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        audioSrc.volume = musicVolume;
    }

    // Method that is called by slider game object
    // This method takes vol value passed by slider and sets it as music value
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
