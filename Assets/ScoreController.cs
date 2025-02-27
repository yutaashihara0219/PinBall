
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject scoreText;

    //得点を定義
    private int score = 0;

    private int addscore1 = 0;
    private int addscore2 = 0;
    private int addscore3 = 0;
    private int addscore4 = 0;



    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextを取得する
        this.scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        // タグによって得点を変える
        if (tag == "SmallStarTag")
        {
            this.addscore1 += 2;
        }
        else if (tag == "LargeStarTag")
        {
            this.addscore2 += 3;
        }
        else if (tag == "SmallCloudTag")
        {
            this.addscore3 += 5;
        }
        else if (tag == "LargeCloudTag")
        {
            this.addscore4 += 8;
        }

        //得点を増やす
        this.score = this.addscore1 + this.addscore2 + this.addscore3 + this.addscore4;

        this.scoreText.GetComponent<Text>().text = "得点：" + this.score;
    }
}