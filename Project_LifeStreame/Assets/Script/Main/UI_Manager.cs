using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// メインシーンのUIの表示などを管理するスクリプト
/// </summary>
public class UI_Manager : MonoBehaviour
{
    public GameObject UIControllerPref;
    GameObject UIController;
    public GameObject menuButton;
    public Text ButtonMessage;
    public GameObject[] contentButton;
    private bool click;
    private GameObject menu;

    /// <summary>
    /// ライセンス取得メニューを表示するアニメーション
    /// </summary>
    public void moveAnimation()
    {
        if (!click)
        {
            click = true;
            if (UIController == null)
            { //UIControllerが存在しなければ生成
                UIController = Instantiate(UIControllerPref) as GameObject;
            }
            ButtonMessage.text = "▲";
        } else {
            click = false;
            menuEnabled();
            ButtonMessage.text = "▼";
        }
    }

    /// <summary>
    /// UIのボタンの表示非表示を切り替えるメソッド
    /// </summary>
    /// <param name="active">trueなら配列の中のボタンをtrueにする</param>
    public void contentActiverter(bool active)
    {
        for (int i = 0; i < contentButton.Length; i++)
        {
            contentButton[i].SetActive(active);
        }
    }

    /// <summary>
    /// 資格取得メニューを消去する
    /// </summary>
    void menuEnabled()
    {
        menu = GameObject.Find("menu_Canvas(Clone)");
        Destroy(menu.gameObject);
    }
}