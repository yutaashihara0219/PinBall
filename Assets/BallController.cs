using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるｚ軸の最小値
    private float visiblePosz = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のＧａｍｅＯｖｅｒＴｅｘｔオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosz)
        {
            //GameoverTextにゲームオーバーを表示する
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
