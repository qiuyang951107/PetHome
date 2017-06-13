using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio3 : MonoBehaviour
{

    //将准备好的MP3格式的背景声音文件拖入此处  
    public AudioClip backgroundMusic;

    //将准备好的MP3格式的音效文件拖入此处  
    public AudioClip palyOnceSound;

    //用于控制声音的AudioSource组件  
    private AudioSource _audioSource;


    void Awake()
    {
        //在添加此脚本的对象中添加AudioSource组件，此处为摄像机  
        _audioSource = this.gameObject.AddComponent<AudioSource>();

        //设置循环播放  
        _audioSource.loop = true;

        //设置音量为最大，区间在0-1之间  
        _audioSource.volume = 1.0f;

        //设置audioClip  
        _audioSource.clip = backgroundMusic;
    }

        //绘制添加音效按钮,PlayOnShot方式添加音效   _audioSource.PlayOneShot(palyOnceSound);

        //绘制添加音效按钮，PlayClipAtPoint方式添加音效  
        // AudioSource.PlayClipAtPoint(palyOnceSound, _audioSource.transform.localPosition);

    public GameObject btndown;
    Button btn;
    void Start()
    {
        btn = btndown.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
        {
            _audioSource.PlayOneShot(palyOnceSound);
        });
    }
}