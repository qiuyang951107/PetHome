//再就是这些音乐与音效的分离，  
//实现思路：音效呢就是点击的声音片段，我用了AudioClip，  
//然后初始化了AudioSource控件，定义一个音效的控件  
//public AudioSource music；这个music用来控制音效的，  
//因为两个音效是用声音片段AudioClip定义的，我并没有查到他的播放与暂停，  
//所以定义了一个声音资源，来总的控制，  
//music.PlayOneShot(beep);这样点击发出音效；  
//当music.volume = 0;时，音效声音为0，  
//实现了音效的关闭，  
//而音乐呢，直接拖到了AudioSource的AudioClip上，  
//这样呢，当audio.Stop();时，背景音乐停止
using System.Collections;

using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour {

    public AudioClip beep;//音效
    private AudioSource music;//控制声音的组件
    public Toggle toggle1;//音乐按钮
    public Toggle toggle2;//音效按钮
    public bool kai2=true ;//音效
    public GameObject btndown;
    Button btn;
	// Use this for initialization
	void Start () {
        music = gameObject.AddComponent<AudioSource>();   
        toggle1.onValueChanged.AddListener(OnValueChanged1);
        toggle2.onValueChanged.AddListener(OnValueChanged2);

        //实验按钮
        btn = btndown.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
        {
            music.PlayOneShot(beep);
        });
	}
    void OnValueChanged1(bool check)//背景音乐控制按钮
    {
        music.PlayOneShot(beep);
    }
    void OnValueChanged2(bool check)//音效控制
    {
        music.PlayOneShot(beep);
        if (kai2 == true)
        {
            music.volume = 0;
            kai2 = false;
        }
        else
        {
            music.volume = 1;
            kai2 = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
