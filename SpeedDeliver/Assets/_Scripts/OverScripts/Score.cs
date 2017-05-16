using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text distanceText;
    public Text incomeText;
    public Text currentText;
    public Text bestText;
	// Use this for initialization
	void Start () {
		//更新BestScore和CurrentText
        float distanceScore = PlayerPrefs.GetFloat("Distance");
        float incomeScore = PlayerPrefs.GetFloat("Income");
        float bestScore = PlayerPrefs.GetFloat("BestScore");
        float currentScore = PlayerPrefs.GetFloat("CurrentScore");

        distanceText.GetComponent<Text>().text = "奔跑距离：" + distanceScore.ToString("f0");
        incomeText.GetComponent<Text>().text =  "金       币：" + incomeScore.ToString("f0");
        currentText.GetComponent<Text>().text = "总       分：" + currentScore.ToString("f0");
        bestText.GetComponent<Text>().text = "最佳成绩：" + bestScore.ToString("f0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
