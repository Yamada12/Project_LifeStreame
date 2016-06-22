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
        if (PlayerStatus.mf == 0)
        {//男性の場合
            for (int i = 0; i < basePoint_m.Length; i++)
            {//男性のボタンを消去する
                basePoint_m[i].SetActive(false);
            }

            if (PlayerStatus.marriage == 0)//jokerで加算してもらう
            {//誰とも付き合っていなければ
                if (PlayerStatus.lp_tun <= 0)//ツンデレに出会っていなければインタラクティブをFalseにする
                    basePoint_f[0].GetComponentInChildren<Button>().interactable = false;
                else
                    basePoint_f[0].GetComponentInChildren<Button>().interactable = true;

                if (PlayerStatus.lp_maji <= 0)//真面目ちゃんに出会っていなければインタラクティブをFalseにする
                    basePoint_f[1].GetComponentInChildren<Button>().interactable = false;
                else
                    basePoint_f[1].GetComponentInChildren<Button>().interactable = true;

                if (PlayerStatus.lp_supo <= 0)//スポコンに出会っていなければインタラクティブをFalseにする
                    basePoint_f[2].GetComponentInChildren<Button>().interactable = false;
                else
                    basePoint_f[2].GetComponentInChildren<Button>().interactable = true;
            }
            else {
                switch (PlayerStatus.marriage)
                {//誰と付き合っているか
                    case 1://ツンデレ
                        for (int i = 0; i < basePoint_f.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_f[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_f[0].GetComponentInChildren<Button>().interactable = true;
                        break;
                    case 2://真面目ちゃん
                        for (int i = 0; i < basePoint_f.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_f[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_f[1].GetComponentInChildren<Button>().interactable = true;
                        break;
                    case 3://スポコン
                        for (int i = 0; i < basePoint_f.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_f[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_f[2].GetComponentInChildren<Button>().interactable = true;
                        break;
                    case 4://控え目(予定)
                        for (int i = 0; i < basePoint_f.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_f[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_f[3].GetComponentInChildren<Button>().interactable = true;
                        break;
                }
            }
        }
        else
        {//その他（女性）の場合
            for (int i = 0; i < basePoint_f.Length; i++)
            {//女性のボタンを消去する
                basePoint_f[i].SetActive(false);
            }

            if (PlayerStatus.marriage == 0)//jokerで加算してもらう
            {//誰とも付き合っていなければ
                if (PlayerStatus.lp_mega <= 0)//インテリメガネに出会っていなければインタラクティブをFalseにする
                    basePoint_m[0].GetComponentInChildren<Button>().interactable = false;
                else
                    basePoint_m[0].GetComponentInChildren<Button>().interactable = true;

                if (PlayerStatus.lp_kama <= 0)//カマセに出会っていなければインタラクティブをFalseにする
                    basePoint_m[1].GetComponentInChildren<Button>().interactable = false;
                else
                    basePoint_m[1].GetComponentInChildren<Button>().interactable = true;

                if (PlayerStatus.lp_nago <= 0)//和やかに出会っていなければインタラクティブをFalseにする
                    basePoint_m[2].GetComponentInChildren<Button>().interactable = false;
                else
                    basePoint_m[2].GetComponentInChildren<Button>().interactable = true;
            }
            else {
                switch (PlayerStatus.marriage)
                {//誰と付き合っているか
                    case 1://テリメガ
                        for (int i = 0; i < basePoint_m.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_m[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_m[0].GetComponentInChildren<Button>().interactable = true;
                        break;
                    case 2://カマセ
                        for (int i = 0; i < basePoint_m.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_m[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_m[1].GetComponentInChildren<Button>().interactable = true;
                        break;
                    case 3://和やか
                        for (int i = 0; i < basePoint_m.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_m[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_m[2].GetComponentInChildren<Button>().interactable = true;
                        break;
                    case 4://オレ様(予定)
                        for (int i = 0; i < basePoint_m.Length; i++)
                        {//特定のボタン以外をオフにする
                            basePoint_m[i].GetComponentInChildren<Button>().interactable = false;
                        }
                        basePoint_m[3].GetComponentInChildren<Button>().interactable = true;
                        break;
                }
            }
        }
    }

    /// <summary>
    /// イベントボタンを展開する
    /// </summary>
    public void OpenDetail(int id)
    {
        if (PlayerStatus.mf == 0)
        {//男性の場合
            for (int i = 0; i < targetDetail_f.Length; i++)
            {//全ての詳細パネルを消去
                targetDetail_f[i].SetActive(false);
                targetDetail_m[i].SetActive(false);
            }
            //特定IDの詳細のみアクティブにしてアニメーションさせる
            if (PlayerStatus.marriage != 0)//付き合っていれば
                targetDetail_f[id + 5].SetActive(true);
            else
                targetDetail_f[id].SetActive(true);

            iTween.ScaleFrom(targetDetail_f[id], iTween.Hash("x", 0.1f, "y", 0.1f, "z", 0.1f, "time", 0.5f));
            iTween.MoveFrom(targetDetail_f[id], iTween.Hash("position", basePoint_f[id].gameObject.transform.position, "time", 0.5f));
            SoundPlayer.Instance.PlaySE("SmartPhone_Enter");
        }
        else
        {//女性の場合
            for (int i = 0; i < targetDetail_m.Length; i++)
            {//全ての詳細パネルを消去
                targetDetail_f[i].SetActive(false);
                targetDetail_m[i].SetActive(false);
            }
            //特定IDの詳細のみアクティブにしてアニメーションさせる
            if(PlayerStatus.marriage > 0)//付き合っていれば
                targetDetail_m[id + 5].SetActive(true);
            else
                targetDetail_m[id].SetActive(true);

            iTween.ScaleFrom(targetDetail_m[id], iTween.Hash("x", 0.1f, "y", 0.1f, "z", 0.1f, "time", 0.5f));
            iTween.MoveFrom(targetDetail_m[id], iTween.Hash("position", basePoint_m[id].gameObject.transform.position, "time", 0.5f));
            SoundPlayer.Instance.PlaySE("SmartPhone_Enter");
        }
    }
}