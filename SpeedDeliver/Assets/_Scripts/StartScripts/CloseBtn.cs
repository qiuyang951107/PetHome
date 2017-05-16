using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CloseBtn : MonoBehaviour
{
    public GameObject btndown;
    public GameObject panel;
    public Sprite expan;
    public Sprite back;
    Button btn;
    bool isshow = false;
    // Use this for initialization
    void Start()
    {
        panel.SetActive(isshow);
        btn = btndown.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
        {
            isshow = !isshow;
            panel.SetActive(isshow);
            if (isshow)
            {
                btn.GetComponent<Image>().sprite = expan;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}