using UnityEngine;

public class RestartSensor : MonoBehaviour
{
    public TutorialMaster tm; //�Ǘ��p�X�N���v�g

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //�v���C���[���R���C�_�[�ɓ������Ƃ�
        {
            //�����[�h���Ȃ��ꍇ
            other.gameObject.transform.position = tm.lastCheckPointPos; //�v���C���[���ŏI�`�F�b�N�|�C���g�̈ʒu�Ɉړ�����

            //�����[�h����ꍇ
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //���݂̃V�[�������[�h����i�����[�h�j
        }
    }
}
