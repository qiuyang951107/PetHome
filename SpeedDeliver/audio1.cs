using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio1 : MonoBehaviour {
    public AudioSource music;
    public GameObject btndown;
    Button btn;
	// Use this for initialization
	void Start () {
        btn = btndown.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
    {
        if (!music.isPlaying)
        {
            music.Play();
        }
        else
        {
            music.Stop();
        }
    });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
