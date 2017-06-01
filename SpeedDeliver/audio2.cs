using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio2 : MonoBehaviour
{
    public AudioSource music;
    public Toggle toggle;
    // Use this for initialization
    void Start()
    {
        toggle.onValueChanged.AddListener(OnValueChanged); 
    }
    void OnValueChanged(bool check)
    {
        if (!music.isPlaying)
        {
            music.Play();
        }
        else
        {
            music.Stop();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}