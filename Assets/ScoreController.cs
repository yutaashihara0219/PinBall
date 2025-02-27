
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ScoreController : MonoBehaviour
{
    //���_��\������e�L�X�g
    private GameObject scoreText;

    //���_���`
    private int score = 0;

    private int addscore1 = 0;
    private int addscore2 = 0;
    private int addscore3 = 0;
    private int addscore4 = 0;



    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText���擾����
        this.scoreText = GameObject.Find("ScoreText");


    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnCollisionEnter(Collision collision)
    {
        // �^�O�ɂ���ē��_��ς���
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.addscore1 += 2;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.addscore2 += 3;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            this.addscore3 += 5;
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            this.addscore4 += 8;
        }

        //���_�𑝂₷
        this.score = this.addscore1 + this.addscore2 + this.addscore3 + this.addscore4;

        this.scoreText.GetComponent<Text>().text = "���_�F" + this.score;
    }
}