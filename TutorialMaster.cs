using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMaster : MonoBehaviour
{
    public Vector3 lastCheckPointPos; //�ŏI�`�F�b�N�|�C���g

    void Start()
    {
        lastCheckPointPos = firstCheckPointPos; //�`�F�b�N�|�C���g�������`�F�b�N�|�C���g�ɐݒ肷��
    }

    //�����[�h����ꍇ
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //�����[�h���Ă��������ɕێ�����
    }
}
