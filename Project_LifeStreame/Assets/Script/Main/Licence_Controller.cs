﻿using UnityEngine;
using System.Collections;

/// <summary>
/// ボタンのアニメーションを管理するスクリプト
/// 動きをつけるボタンにアタッチする
/// </summary>
public class Licence_Controller : MonoBehaviour
{
    public GameObject[] Left;       //左から来るボタンが入る
    public GameObject[] Right;      //右から来るボタンが入る

    public GameObject[] LeftBase;   //左から来るボタンのアニメーション開始前の座標地点
    public GameObject[] RightBase;  //右から来るボタンのアニメーション開始前の座標地点

    Vector3[] LeftPositions;
    Vector3[] RightPositions;

    void Start()
    {
        this.fadeIn(); //プレハブが生成されたらフェードイン処理を実行
    }

    /// <summary>
    /// フェードイン
    /// </summary>
    void fadeIn()
    {
        for (int i = 0; i < Left.Length; i++)
        {
            this.moveAction(Left[i], true, true, LeftBase[i].transform.position, i);
        }
        for (int i = 0; i < Right.Length; i++)
        {
            this.moveAction(Right[i], true, false, RightBase[i].transform.position, i);
        }
    }

    /// <summary>
    /// フェードアウト
    /// </summary>
    void fadeOut()
    {
        for (int i = 0; i < Left.Length; i++)
        {
            this.moveAction(Left[i], false, true, LeftBase[i].transform.position, i);
        }
        for (int i = 0; i < Right.Length; i++)
        {
            this.moveAction(Right[i], false, false, RightBase[i].transform.position, i);
        }
        Invoke("DestroySelf", 0.5f);
    }

    /// <summary>
    /// アニメーション
    /// </summary>
    void moveAction(GameObject pObj, bool isIn, bool isLeft, Vector3 basePos, int pOrder)
    {
        if (isIn)
        {
            //iTween.MoveFrom(pObj, iTween.Hash("x", xPos, "time", TIME, "delay", pOrder * DELAY));   // アニメーション開始をpOrder*DELAYの間遅らせる
            iTween.MoveFrom(pObj, iTween.Hash("position", basePos, "time", 1.0f, "delay", pOrder * 0.3f));
            iTween.FadeFrom(pObj, iTween.Hash("a", 0f, "time", 1.0f, "delay", pOrder * 0.3f));
        } else {
            //iTween.MoveTo(pObj, iTween.Hash("x", xPos, "time", TIME, "delay", pOrder * DELAY));     // アニメーション開始をpOrder*DELAYの間遅らせる
            iTween.MoveTo(pObj, iTween.Hash("position", basePos, "time", 1.0f, "delay", pOrder * 0.3f));
            iTween.FadeTo(pObj, iTween.Hash("a", 0f, "time", 1.0f, "delay", pOrder * 0.3f));
        }
    }

    /// <summary>
    /// メニューを閉じる
    /// </summary>
    public void ClosedMenu()
    {
        fadeOut();
    }

    /// <summary>
    /// 自身を消去する
    /// </summary>
    void DestroySelf()
    {
        Destroy(this.gameObject);
    }
}