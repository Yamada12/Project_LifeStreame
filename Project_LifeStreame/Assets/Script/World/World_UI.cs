using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// WorldシーンのUIを管理するスクリプト
/// リストに値を加える。
/// 空オブジェクト　World_UIにアタッチ
/// </summary>
public class World_UI : MonoBehaviour {

    public GUIStyle Box;
    public GUIStyle Text;
    public GUIStyle Button;

    public GameObject image01;//試験前表示UI
    public GameObject image02;//試験後表示UI

    // Use this for initialization
    void Start () {//世代数と名前を参照する
        PlayerStatus.initStatus();
    }

    public void OnGUI () {//プレイヤーの基本情報表示(世代数、名前)
        GUI.skin.textField.fontSize = 35;
        GUI.skin.box.fontSize = 50;
        GUI.skin.button.fontSize = 30;

        //第〇世代〇〇家
        GUI.Box(new Rect(Screen.width / 2 - 550, Screen.height / 2 - 300, 500, 100), "",Box);
        GUI.TextArea(new Rect(Screen.width / 2 - 500, Screen.height / 2 - 280, 500, 100),"第" + PlayerStatus.geneNumber + "世代" + PlayerStatus.clanName + "家", Text);

        //試験前・試験後のUIを表示する
        //イメージオブジェクトをimage01・image02にアタッチ
        if (World_Player.UI01 == 1)//試験前
        {
            iTween.MoveTo(image01, iTween.Hash("z", -5f, "time", 3.0f));//image01を右下からにゅっと
        }

        if (World_Player.UI02 == 1)//試験後
        {
            iTween.MoveTo(image02, iTween.Hash("z", -5f, "time", 3.0f));//image02を右下からにゅっと
        }

    }


}
