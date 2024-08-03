using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoint : MonoBehaviour
{
    public TutorialMaster tm; //管理用スクリプト

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //プレイヤーがコライダーに入ったとき
        {
            tm.lastCheckPointPos = transform.position; //このチェックポイントの位置を最終チェックポイントに設定する
        }
    }
}
