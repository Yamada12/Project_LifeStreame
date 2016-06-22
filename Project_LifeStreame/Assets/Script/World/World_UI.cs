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

    public GameObject start01;//小学生　始まりUI
    public GameObject start02;//中学生　始まりUI
    public GameObject start03;//高校　始まりUI
    public GameObject start04;//人生の選択　始まりUI
    public GameObject start05;//専門学校　始まりUI
    public GameObject start06;//大学　始まりUI
    public GameObject start07;//社会人　始まりUI
    public GameObject start08;//歳より　始まりUI

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
        GUI.Box(new Rect(Screen.width / 2 - 500, Screen.height / 2 - 270, 500, 100), "第" + PlayerStatus.geneNumber + "世代" + PlayerStatus.clanName + "家", Box);

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
            iTween.MoveTo(image08, iTween.Hash("z", -10f, "time", 2.0f));//お迎え看板を右下からにゅっと
        }

        if(World_Player.shiken == 0)//何パートか？　確認UI 
        {
            if(PlayerStatus.progress == 1)//小学生パート
            {
                iTween.MoveTo(start01, iTween.Hash("delay", 0.5f, "x", -60, "time", 1.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 2)//中学生パート
            {
                iTween.MoveTo(start02, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 3)//高校パート
            {
                iTween.MoveTo(start03, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 4)//人生の選択パート
            {
                iTween.MoveTo(start04, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 5)//専門学校パート
            {
                iTween.MoveTo(start05, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 6)//大学パート
            {
                iTween.MoveTo(start06, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 7)//社会人パート
            {
                iTween.MoveTo(start07, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }

            if (PlayerStatus.progress == 8)//歳よりパート
            {
                iTween.MoveTo(start08, iTween.Hash("x", -60, "time", 7.0f));//スタート小学校を左からにゅっと
            }
        }


        if (PlayerStatus.progress == 4)//高校卒業後
        {
            if(World_Player.Select_Button == 1)
            {//選択肢３つ出てくる 専門学校・大学・就職
                iTween.ScaleTo(image03, iTween.Hash("delay", 1f, "x", 1, "y", 1.3, "time", 2.0f, "oncomplete", "Click", "oncompletetarget", gameObject));
                iTween.ScaleTo(image04, iTween.Hash("delay", 1f, "x", 1, "y", 1.3, "time", 2.0f, "oncomplete", "Click", "oncompletetarget", gameObject));
                iTween.ScaleTo(image05, iTween.Hash("delay", 1f, "x", 1, "y", 1.3, "time", 2.0f, "oncomplete", "Click", "oncompletetarget", gameObject));
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
