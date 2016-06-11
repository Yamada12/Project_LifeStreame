using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// ボタンのアニメーションを管理するスクリプト
/// 動きをつけるボタンにアタッチする
/// </summary>
public class Love_Controller : MonoBehaviour
{
    public GameObject[] targetDetail_f;  //アニメーションさせたいイメージ（女性）
    public GameObject[] basePoint_f;        //初期位置(女性キャラ選択ボタン)
    public GameObject[] targetDetail_m;  //アニメーションさせたいイメージ（男性）
    public GameObject[] basePoint_m;        //初期位置(男性キャラ選択ボタン)

    /// <summary>
    /// 性別に応じてボタンを切り替える
    /// </summary>
    void Start()
    {
        if (PlayerStatus.mf == 1)
        {//女性の場合
            for (int i = 0; i < targetDetail_m.Length; i++)
            {//男性のボタンを消去する
                basePoint_m[i].SetActive(false);
            }
        }
        else
        {//その他（男性）の場合
            for (int i = 0; i < targetDetail_f.Length; i++)
            {//女性のボタンを消去する
                basePoint_f[i].SetActive(false);
            }
        }
    }

    /// <summary>
    /// イベントボタンを展開する
    /// </summary>
    public void OpenDetail(int id)
    {
        if (PlayerStatus.mf == 1)
        {//女性の場合
            for (int i = 0; i < targetDetail_f.Length; i++)
            {//全ての詳細パネルを消去
                targetDetail_f[i].SetActive(false);
                targetDetail_m[i].SetActive(false);
            }
            //特定IDの詳細のみアクティブにしてアニメーションさせる
            targetDetail_f[id].SetActive(true);

            iTween.ScaleFrom(targetDetail_f[id], iTween.Hash("x", 0.1f, "y", 0.1f, "z", 0.1f, "time", 0.5f));
            iTween.MoveFrom(targetDetail_f[id], iTween.Hash("position", basePoint_f[id].gameObject.transform.position, "time", 0.5f));
        }
        else
        {//男性の場合
            for (int i = 0; i < targetDetail_m.Length; i++)
            {//全ての詳細パネルを消去
                targetDetail_f[i].SetActive(false);
                targetDetail_m[i].SetActive(false);
            }
            //特定IDの詳細のみアクティブにしてアニメーションさせる
            targetDetail_m[id].SetActive(true);

            iTween.ScaleFrom(targetDetail_m[id], iTween.Hash("x", 0.1f, "y", 0.1f, "z", 0.1f, "time", 0.5f));
            iTween.MoveFrom(targetDetail_m[id], iTween.Hash("position", basePoint_m[id].gameObject.transform.position, "time", 0.5f));
        }
    }
}