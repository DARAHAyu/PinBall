using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    //Start is called before the first frame update
    private void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }

    //Update is called once per frame
    private void Update()
    {
        //左矢印キーを押したとき左フリッパーを動かす
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tag ==
            "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //右矢印キーを押したとき左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag ==
            "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // 発展課題②：Aキーを押したときに左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // 発展課題③：Dキーを押したときに右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }


        // 発展課題④：Sキーまたは下矢印キーを押したときは同時に左右のフリッパーを動かす
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetAngle(this.flickAngle);
        }

        //矢印キーが離された時フリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag ==
            "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag ==
            "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        // 発展課題⑤：タップが終わったときにフリッパーを元の位置に戻す
        if (Input.GetKeyUp(KeyCode.A) && tag ==
            "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.D) && tag ==
   　　　　 "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            SetAngle(this.defaultAngle);
        }

    }
    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}