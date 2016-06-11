using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// WorldシーンのUIを管理するスクリプト
/// リストに値を加える。
/// 空オブジェクト　World_UIにアタッチ
/// </summary>
public class World_UI : MonoBehaviour {

    //static public int progress = 4;//デバック用変数

    public GUIStyle Box;
    public GUIStyle Text;
    public GUIStyle Button;

    public GameObject image01;//試験前看板（試験）
    public GameObject image02;//試験後看板（入学）
    public GameObject image03;//専門学校ボタン
    public GameObject image04;//大学ボタン
    public GameObject image05;//就職ボタン
    public GameObject image06;//人生の選択看板（選択）
    public GameObject image07;//社会人看板（迎え）
    public GameObject image08;//年寄り看板

    // Use this for initialization
    void Start () {//世代数と名前を参照する
        //PlayerStatus.initStatus();
        Debug.Log("世代名:" + PlayerStatus.clanName);
        Debug.Log("進行度:" + PlayerStatus.progress);
    }

    public void OnGUI () {//プレイヤーの基本情報表示(世代数、名前)
        GUI.skin.textField.fontSize = 35;
        GUI.skin.box.fontSize = 50;
        GUI.skin.button.fontSize = 30;

        //第〇世代〇〇家
        GUI.Box(new Rect(Screen.width / 2 - 550, Screen.height / 2 - 300, 500, 100), "",Box);
        GUI.TextArea(new Rect(Screen.width / 2 - 500, Screen.height / 2 - 280, 500, 100),"第" + PlayerStatus.geneNumber + "世代" + PlayerStatus.clanName + "家", Text);

        //試験前・試験後・人生の選択・社会人・年寄りの看板・ボタンを表示する
        //イメージオブジェクトをそれぞれにアタッチ
        if (World_Player.kanban_shiken == 1)//試験前
        {
            iTween.MoveTo(image01, iTween.Hash("z", -5f, "time", 2.0f));//試験看板を右下からにゅっと
        }

        if (World_Player.kanban_nyugaku == 1)//試験後
        {
            iTween.MoveTo(image02, iTween.Hash("z", -5f, "time", 2.0f));//入学看板を右下からにゅっと
        }

        if (World_Player.Select_Button == 1)//人生の選択
        {
            iTween.MoveTo(image06, iTween.Hash("z", -5f, "time", 2.0f));//選択看板を右下からにゅっと
        }

        if (World_Player.kanban_shakai == 1)//
        {
            iTween.MoveTo(image07, iTween.Hash("z", -5f, "time", 2.0f));//入社看板を右下からにゅっと
        }

        if (World_Player.kanban_toshiyori == 2)//
        {
            iTween.MoveTo(image08, iTween.Hash("z", -5f, "time", 2.0f));//お迎え看板を右下からにゅっと
        }

        if (PlayerStatus.progress == 4)//高校卒業後
        {
            if(World_Player.Select_Button == 1)
            {//選択肢３つ出てくる 専門学校・大学・就職
                iTween.ScaleTo(image03, iTween.Hash("x", 1, "y", 0.7, "time", 2.0f, "oncomplete", "Click", "oncompletetarget", gameObject));
                iTween.ScaleTo(image04, iTween.Hash("x", 1, "y", 0.7, "time", 2.0f, "oncomplete", "Click", "oncompletetarget", gameObject));
                iTween.ScaleTo(image05, iTween.Hash("x", 1, "y", 0.7, "time", 2.0f, "oncomplete", "Click", "oncompletetarget", gameObject));
            }
        }

    }

    public void Click()
    {
        if(World_SelectButton.Life >= 1)
        {//クリックしたら選択肢３つが消える
            iTween.ScaleBy(image03, iTween.Hash("x", 0, "y", 0, "time", 2.0f));
            iTween.ScaleBy(image04, iTween.Hash("x", 0, "y", 0, "time", 2.0f));
            iTween.ScaleBy(image05, iTween.Hash("x", 0, "y", 0, "time", 2.0f));
        }
    }




}
