using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public TutorialMaster tm; //�Ǘ��p�X�N���v�g

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //�v���C���[���R���C�_�[�ɓ������Ƃ�
        {
            tm.lastCheckPointPos = transform.position; //���̃`�F�b�N�|�C���g�̈ʒu���ŏI�`�F�b�N�|�C���g�ɐݒ肷��
        }
    }
}
