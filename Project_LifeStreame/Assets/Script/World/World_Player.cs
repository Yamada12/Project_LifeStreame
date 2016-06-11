using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Worldシーン　試験シーンの結果を受け取るスクリプト
/// Worldシーン　Player01のTriggerを判定をするスクリプト
/// オブジェクト　Player01にアタッチ
/// </summary>

public class World_Player : MonoBehaviour {

    static public int result;
    static public int kanban_shiken;
    static public int kanban_nyugaku;
    static public int Select_Button;
    static public int kanban_shakai;
    static public int kanban_toshiyori;
    static public int Spawner;

    void Awake()
    {
        kanban_shiken = 0;
        kanban_nyugaku = 0;
        Select_Button = 0;
        kanban_shakai = 0;
        kanban_toshiyori = 0;

 
        if (StatusManager.variable.get("f.test") == "null")//シーン開始時、nullのため
        {
            result = 0;
            StatusManager.variable.set("f.test", ((int)result).ToString());
        }

        if (StatusManager.variable.get("f.test") != "null")//試験後、値代入
        {
            result = int.Parse(StatusManager.variable.get("f.test"));
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "turning_Before")
        {
            kanban_shiken = 1;
        }
        if (other.gameObject.tag == "turning_After")
        {
            kanban_nyugaku = 1;
        }
        if(other.gameObject.tag == "select_Button")
        {
            Select_Button = 1;
        }
        if(other.gameObject.tag == "select_Button2")
        {
            Select_Button = 2;
        }
        if(other.gameObject.tag == "shakai")
        {
            kanban_shakai = 1;
        }
        if(other.gameObject.tag == "toshiyori")
        {
            kanban_toshiyori = 1;
        }
        if (other.gameObject.tag == "Spawner")
        {
            Spawner = 1;
        }

        //小学校
        if (other.gameObject.tag == "Target_ES")
        {
            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if(other.gameObject.tag == "ES_s")
        {
            SceneManager.LoadScene("Main_ElementarySchool");//メイン小学校へ
        }
        if (other.gameObject.tag == "ES_h")
        {
            SceneManager.LoadScene("Main_ElementarySchool");//メイン小学校へ
        }
        if (other.gameObject.tag == "ES_y")
        {
            SceneManager.LoadScene("Main_ElementarySchool");//メイン小学校へ
        }




        
        //中学校
        if (other.gameObject.tag == "Target_JHS")
        {
            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//中学校試験シーンへ
        }
        //中学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "JHS_s")
        {
            SceneManager.LoadScene("Main_JuniorHighSchool");//メイン中学校へ
        }
        if (other.gameObject.tag == "JHS_h")
        {
            SceneManager.LoadScene("Main_JuniorHighSchool");//メイン中学校へ
        }
        if (other.gameObject.tag == "JHS_y")
        {
            SceneManager.LoadScene("Main_JuniorHighSchool");//メイン中学校へ
        }




        
        //高校
        if (other.gameObject.tag == "Target_HS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//高校試験シーンへ
        }
        //高校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "HS_s")
        {
            SceneManager.LoadScene("Main_HighSchool");//メイン高校へ
        }
        if (other.gameObject.tag == "HS_h")
        {
            SceneManager.LoadScene("Main_HighSchool");//メイン高校へ
        }
        if (other.gameObject.tag == "HS_y")
        {
            SceneManager.LoadScene("Main_HighSchool");//メイン高校へ
        }



        //人生の選択
        if (other.gameObject.tag == "Select_PS")
        {
            PlayerStatus.progress = 5;
            SceneManager.LoadScene("World");//再読み込み　専門学校へ
        }
        if (other.gameObject.tag == "Select_U")
        {
            PlayerStatus.progress = 6;
            SceneManager.LoadScene("World");//再読み込み　大学へ
        }
        if (other.gameObject.tag == "Select_MOS")
        {
            PlayerStatus.progress = 7;
            SceneManager.LoadScene("World");//再読み込み　社会人へ
        }





        //専門学校
        if (other.gameObject.tag == "Target_PS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//専門学校試験シーンへ
        }
        //専門学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "PS_s")
        {
            SceneManager.LoadScene("Main_ProfessionalSchool");//メイン専門学校へ
        }
        if (other.gameObject.tag == "PS_h")
        {
            SceneManager.LoadScene("Main_ProfessionalSchool");//メイン専門学校へ
        }
        if (other.gameObject.tag == "PS_y")
        {
            SceneManager.LoadScene("Main_ProfessionalSchool");//メイン専門学校へ
        }




        
        //大学
        if (other.gameObject.tag == "Target_U")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//大学試験シーンへ
        }
        //大学しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "U_s")
        {
            SceneManager.LoadScene("Main_College");//メイン大学へ
        }
        if (other.gameObject.tag == "U_h")
        {
            SceneManager.LoadScene("Main_College");//メイン大学へ
        }
        if (other.gameObject.tag == "U_y")
        {
            SceneManager.LoadScene("Main_College");//メイン大学へ
        }




        
        //社会人
        if (other.gameObject.tag == "Target_MOS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//社会人試験シーンへ
        }
        //ビルにレッツゴー
        if (other.gameObject.tag == "MOS")
        {
            SceneManager.LoadScene("Main_Society");//メイン社会人へ
        }
    }
}

