using UnityEngine;

public class Player : MonoBehaviour
{
    public TutorialMaster tm; //�Ǘ��p�X�N���v�g

    void Start()
    {
        //�����[�h����ꍇ
        transform.position = tm.lastCheckPointPos; //�v���C���[���ŏI�`�F�b�N�|�C���g�̈ʒu�Ɉړ�����
    }
}
