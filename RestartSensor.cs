using UnityEngine;

public class RestartSensor : MonoBehaviour
{
    public TutorialMaster tm; //管理用スクリプト

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //プレイヤーがコライダーに入ったとき
        {
            //リロードしない場合
            other.gameObject.transform.position = tm.lastCheckPointPos; //プレイヤーを最終チェックポイントの位置に移動する

            //リロードする場合
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //現在のシーンをロードする（リロード）
        }
    }
}
