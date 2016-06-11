using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// ボタンの使用を管理するスクリプト
/// メイン管理オブジェクトにアタッチする
/// 必ずボタンの配列とその他の配列の要素数を一致させる事
/// </summary>
public class EventButton_Manager : MonoBehaviour
{
    public GameObject awakePanel;
    public Button[] buttons;    //各種ボタン
    public int[] useCounts;    //ボタンの使用回数
    public float[] lostTimes;    //消費時間
    public string[] buttonID;  //各ボタンのID

    void Awake()
    {
        if (!PlayerPrefs.HasKey("0"))
        {
            awakePanel.SetActive(true);
            PlayerStatus.lifeTime = 1200f;
            MainManager.pauseFlag = true;
        } else {
            awakePanel.SetActive(false);
            MainManager.pauseFlag = false;
        }
    }

    /// <summary>
    /// ボタンの使用回数を保存する
    /// </summary>
    public void Save_UseCount()
    {
        Debug.Log(buttons.Length);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttonID[i] = i.ToString();
            PlayerPrefs.SetInt(buttonID[i], useCounts[i]);
        }
        PlayerPrefs.SetFloat("lifeTime", PlayerStatus.lifeTime);
    }

    /// <summary>
    /// ボタンの使用回数を読み込む
    /// </summary>
    public void Load_UseCount()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            useCounts[i] = PlayerPrefs.GetInt(buttonID[i]);
            InteractiveCheck(i);
        }
    }

    /// <summary>
    /// ボタンの使用回数を減らす
    /// </summary>
    /// <param name="id">減らすボタンのID</param>
    public void UseCountDown(int id)
    {
        useCounts[id]--;
        if (useCounts[id] < 0)
            useCounts[id] = 0;

        Save_UseCount();
        InteractiveCheck(id);
    }

    /// <summary>
    /// ボタンの使用回数をチェックする
    /// 0以下であればインタラクティブをfalseにする
    /// </summary>
    /// /// <param name="id">チェックするボタンのID</param>
    public void InteractiveCheck(int id)
    {//id要らないかも？
        //if(useCounts[id] <= 0 || PlayerStatus.lifeTime < lostTimes[id])
        //    buttons[id].interactable = false;

        for(int i = 0; i < useCounts.Length; i++)
        {
            if (useCounts[i] <= 0 || PlayerStatus.lifeTime < lostTimes[i])
                buttons[i].interactable = false;
        }
    }

    /// <summary>
    /// 初回遷移時ボタンの使用回数をリセットする
    /// </summary>
    public void InitDelete()
    {
        for (int i = 100; i < 0; i--)
        {
            PlayerPrefs.DeleteKey(i.ToString());
        }
        Save_UseCount();
        MainManager.pauseFlag = false;
    }

    public void DeleteALL()
    {//デバッグ用セーブデータ全消去
        PlayerPrefs.DeleteKey("0");
        InteractiveCheck(0);
    }
}
