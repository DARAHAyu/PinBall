using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJoint�R���|�[�l���g������
    private HingeJoint myHingeJoint;

    //�����̌X��
    private float defaultAngle = 20;
    //�e�������̌X��
    private float flickAngle = -20;

    //Start is called before the first frame update
    private void Start()
    {
        //HingeJoint�R���|�[�l���g�擾
        this.myHingeJoint = GetComponent<HingeJoint>();

        //�t���b�p�[�̌X����ݒ�
        SetAngle(this.defaultAngle);
    }

    //Update is called once per frame
    private void Update()
    {
        //�����L�[���������Ƃ����t���b�p�[�𓮂���
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tag ==
            "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //�E���L�[���������Ƃ����t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag ==
            "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // ���W�ۑ�A�FA�L�[���������Ƃ��ɍ��t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        // ���W�ۑ�B�FD�L�[���������Ƃ��ɉE�t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }


        // ���W�ۑ�C�FS�L�[�܂��͉����L�[���������Ƃ��͓����ɍ��E�̃t���b�p�[�𓮂���
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetAngle(this.flickAngle);
        }

        //���L�[�������ꂽ���t���b�p�[�����ɖ߂�
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

        // ���W�ۑ�D�F�^�b�v���I������Ƃ��Ƀt���b�p�[�����̈ʒu�ɖ߂�
        if (Input.GetKeyUp(KeyCode.A) && tag ==
            "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.D) && tag ==
   �@�@�@�@ "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            SetAngle(this.defaultAngle);
        }

    }
    //�t���b�p�[�̌X����ݒ�
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}