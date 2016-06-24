using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// ボタンのアニメーションを管理するスクリプト
/// 動きをつけるボタンにアタッチする
/// </summary>
public class Licence_Controller : MonoBehaviour
{
    private ScenarioManager sc = null;

    public GameObject[] Left;       //左から来るボタンが入る
    public GameObject[] Right;      //右から来るボタンが入る

    public GameObject[] LeftBase;   //左から来るボタンのアニメーション開始前の座標地点
    public GameObject[] RightBase;  //右から来るボタンのアニメーション開始前の座標地点

    Vector3[] LeftPositions;
    Vector3[] RightPositions;

    void Start()
    {
        this.fadeIn(); //プレハブが生成されたらフェードイン処理を実行
        sc = GameObject.Find("Main_Manager").GetComponent<ScenarioManager>();
    }

    void Update()
    {
        if (PlayerStatus.lifeTime < 60)
        {
            Left[0].GetComponentInChildren<Button>().interactable = false;
            Left[1].GetComponentInChildren<Button>().interactable = false;
            Left[2].GetComponentInChildren<Button>().interactable = false;
            Left[3].GetComponentInChildren<Button>().interactable = false;
        }
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
        SoundPlayer.Instance.PlaySE("SmartPhone_Cancel");
    }

    /// <summary>
    /// 自身を消去する
    /// </summary>
    void DestroySelf()
    {
        Destroy(this.gameObject);
    }

    /// <summary>
    /// 外出イベント
    /// </summary>
    public void OutDoor(int id)
    {
        switch (id)
        {
            case 0://塾
                if (PlayerStatus.ec >= 300)
                {
                    PlayerStatus.ac += 20;
                    PlayerStatus.co += 5;
                }
                PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
                PlayerPrefs.SetFloat("co", PlayerStatus.co);
                sc.OtherPoper("学力↑", 0f);
                sc.OtherPoper("コミュ力↑", 0.5f);
                break;
            case 1://アルバイト
                PlayerStatus.ec += 20;
                PlayerStatus.vi += 5;
                PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
                PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
                sc.OtherPoper("経済力↑", 0f);
                sc.OtherPoper("体力↑", 0.5f);
                break;
            case 2://遊ぶ
                PlayerStatus.vi += 10;
                PlayerStatus.co += 10;
                PlayerStatus.hu += 5;
                PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
                PlayerPrefs.SetFloat("co", PlayerStatus.co);
                PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
                sc.OtherPoper("体力↑", 0f);
                sc.OtherPoper("コミュ力↑", 0.5f);
                sc.OtherPoper("人間力↑", 1f);
                break;
            case 3://家で休む
                PlayerStatus.lu += 20;
                PlayerStatus.vi += 5;
                PlayerPrefs.SetFloat("lu", PlayerStatus.lu);
                PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
                sc.OtherPoper("運↑", 0f);
                sc.OtherPoper("体力↑", 0.5f);
                break;
            default:
                break;
        }

        PlayerStatus.lifeTime -= 60;
    }
}