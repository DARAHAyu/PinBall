using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // Scoreの最小値
    private int score = 0;

    // Scoreを表示するテキスト
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // 小さい星は＋30点
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 30;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
        // 大きい星は＋10点
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 10;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
        // 小さい雲は＋20点
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 20;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
        // 大きい雲は＋5点
        else if (other.gameObject.tag == "LargeCloudTag")
        { 
            this.score += 5;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
    }
}
