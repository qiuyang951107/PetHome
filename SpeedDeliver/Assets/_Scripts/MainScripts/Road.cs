using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Road : MonoBehaviour
{
    GameObject[] roadArray;
    float speed;
    float distance;

    public Text distanceText;
    public Text incomeText;
    // Use this for initialization
    void Start()
    {
        roadArray = new GameObject[2];
        roadArray[0] = GameObject.Find("Road1");
        roadArray[1] = GameObject.Find("Road2");

    }

    // Update is called once per frame
    void Update()
    {
        speed += 0.1f;
        distance += speed;
        
        distanceText.GetComponent<Text>().text = "距离：" + (distance * 0.001).ToString("f0") + "m";

        Vector3 PeopleP = GameObject.Find("People").transform.position;
        Vector3 car1P = GameObject.Find("car1").transform.position;
        Vector3 car2P = GameObject.Find("car2").transform.position;
        Vector3 car3P = GameObject.Find("car3").transform.position;
        float People_car1_Dis = Vector3.Distance(PeopleP, car1P);
        float People_car2_Dis = Vector3.Distance(PeopleP, car2P);
        float People_car3_Dis = Vector3.Distance(PeopleP, car3P);

        if ((People_car1_Dis < 2.0f) || (People_car2_Dis < 2.0f) || (People_car3_Dis<2.0f))
        {
            //进行了碰撞
            Debug.Log("碰到了");
            //存值
            if (!PlayerPrefs.HasKey("BestScore"))//判断数据是否存在
            {
                PlayerPrefs.SetFloat("BestScore", distance);//保存浮点型数据
                PlayerPrefs.SetFloat("CurrentScore", distance);
            }
            else
            {
                if (distance > PlayerPrefs.GetFloat("BestScore"))//读取浮点型数据
                {
                    PlayerPrefs.SetFloat("BestScore", distance);
                    PlayerPrefs.SetFloat("CurrentScore", distance);
                }
                else
                {
                    PlayerPrefs.SetFloat("CurrentScore", distance);
                }
            }
            //跳转场景
            SceneManager.LoadScene("OverScene");
        }

        for (int i = 0; i < 2; i++)
        {
            if (roadArray[i].transform.position.z < -80.0)
            {
                roadArray[i].transform.position += new Vector3(0, 0, 160);
            }
            else
            {

                roadArray[i].transform.position += new Vector3(0, 0, -0.005f * speed);
            }
        }
    }
    void FixedUpdate()
    {

    }
}
