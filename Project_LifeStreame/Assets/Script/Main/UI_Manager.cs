using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// メインシーンのUIの表示などを管理するスクリプト
/// </summary>
public class UI_Manager : MonoBehaviour
{
    public GameObject licenceControllerPref;
    GameObject licenceController;
    public GameObject loveControllerPref;
    GameObject loveController;
    public GameObject menuButton;
    public Sprite onImage;
    public Sprite offImage;
    public GameObject[] contentButton;
    private bool click;
    private GameObject menu;

    /// <summary>
    /// ライセンス取得メニューを表示するアニメーション
    /// </summary>
    public void moveAnimation(bool smartPhone)
    {
        if (!smartPhone)
        {
            if (!click)
            {
                click = true;
                OpenMenu(0);
                menuButton.GetComponent<Image>().sprite = onImage;
            }
            else {
                click = false;
                menuButton.GetComponent<Image>().sprite = offImage;
                menuEnabled(false);
            }
        }
        else
        {
                OpenMenu(1);
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
    void menuEnabled(bool smartPhone)
    {
        if (!smartPhone)
            menu = GameObject.Find("Licence_Canvas(Clone)");
        else
            menu = GameObject.Find("Love_Canvas(Clone)");

        Destroy(menu.gameObject);
    }

    void OpenMenu(int Num)
    {
        switch (Num)
        {
            case 0: //資格取得パート
                if (licenceController == null)
                { //UIControllerが存在しなければ生成
                    licenceController = Instantiate(licenceControllerPref) as GameObject;
                }
                break;

            case 1: //恋愛パート
                if (loveController == null)
                { //loveControllerが存在しなければ生成
                    loveController = Instantiate(loveControllerPref) as GameObject;
                }
                break;

            default:
                break;
        }
    }
}