using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // Score�̍ŏ��l
    private int score = 0;

    // Score��\������e�L�X�g
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        // �V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // �Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        // ���������́{30�_
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 30;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
        // �傫�����́{10�_
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.score += 10;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
        // �������_�́{20�_
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 20;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
        // �傫���_�́{5�_
        else if (other.gameObject.tag == "LargeCloudTag")
        { 
            this.score += 5;
            this.scoreText.GetComponent<Text>().text = "SCORE:" + score.ToString();
        }
    }
}
