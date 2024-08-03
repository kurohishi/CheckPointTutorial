using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMaster : MonoBehaviour
{
    public Vector3 lastCheckPointPos; //最終チェックポイント

    void Start()
    {
        lastCheckPointPos = firstCheckPointPos; //チェックポイントを初期チェックポイントに設定する
    }

    //リロードする場合
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //リロードしても消えずに保持する
    }
}
