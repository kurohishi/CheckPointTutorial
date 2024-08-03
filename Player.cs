using UnityEngine;

public class Player : MonoBehaviour
{
    public TutorialMaster tm; //管理用スクリプト

    void Start()
    {
        //リロードする場合
        transform.position = tm.lastCheckPointPos; //プレイヤーを最終チェックポイントの位置に移動する
    }
}
