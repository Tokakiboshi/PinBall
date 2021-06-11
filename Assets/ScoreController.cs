using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private float minEmission = 0.3f;
    // Emissionの強度
    private float magEmission = 2.0f;

    //ゲームスコアを表示するテキスト
    private GameObject gamescoreText;
    //スコア計算用変数
    private int score = 0;
    // 角度
    private int degree = 0;


    void Start()
    {
        //シーン中のgamescorerTextオブジェクトを取得
        this.gamescoreText = GameObject.Find("GameScoreText");


    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        //角度を180°に設定
        this.degree = 180;


        //点数の加算
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 20;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 30;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 40;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 50;
        }

        Debug.Log(other.gameObject.tag);

        Debug.Log(score);



        //スコアの表示
        this.gamescoreText.GetComponent<Text>().text = score.ToString();
    }
}
    

   

