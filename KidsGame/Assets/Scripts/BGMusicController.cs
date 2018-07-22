using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusicController : MonoBehaviour {
    // this variable stores the instance of the bg music so it will continue across all screens
    private static BGMusicController instance = null;

    public static BGMusicController Instance
    {
        get { return instance; }
    }


    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
