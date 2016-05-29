using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　試験シーンの結果を受け取るスクリプト
/// Worldシーン　Player01のTriggerを判定をするスクリプト
/// オブジェクト　Player01にアタッチ
/// </summary>

public class World_Player : MonoBehaviour {

    static public int result;
    static public int UI01;
    static public int UI02;
    static public int Spawner;

    void Start()
    {

        //PlayerStatus.initStatus(); //はじめから開始時にすべての変数をリセットするメソッド
        //PlayerStatus.GetConverter();//Jokerから変数を受け取る
        //PlayerStatus.InitConverter();//Jokerに変数を受け渡す
        UI01 = 0;
        UI02 = 0;


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
        if (other.gameObject.tag == "turning_point")
        {
            UI01 = 1;
        }
        if (other.gameObject.tag == "point_turning")
        {
            UI02 = 1;
        }
        if(other.gameObject.tag == "Spawner")
        {
            Spawner = 1;
        }

        //小学校
        if(other.gameObject.tag == "Target_ES")
        {
            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if(other.gameObject.tag == "ES_s")
        {
            Application.LoadLevel("Main_ElementarySchool");//メイン小学校へ
        }
        if (other.gameObject.tag == "ES_h")
        {
            Application.LoadLevel("Main_ElementarySchool");//メイン小学校へ
        }
        if (other.gameObject.tag == "ES_y")
        {
            Application.LoadLevel("Main_ElementarySchool");//メイン小学校へ
        }




        
        //中学校
        if (other.gameObject.tag == "Target_JHS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//中学校試験シーンへ
        }
        //中学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "JHS_s")
        {
            Application.LoadLevel("Main_JuniorHighSchool");//メイン中学校へ
        }
        if (other.gameObject.tag == "JHS_h")
        {
            Application.LoadLevel("Main_JuniorHighSchool");//メイン中学校へ
        }
        if (other.gameObject.tag == "JHS_y")
        {
            Application.LoadLevel("Main_JuniorHighSchool");//メイン中学校へ
        }




        
        //高校
        if (other.gameObject.tag == "Target_HS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//高校試験シーンへ
        }
        //高校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "HS_s")
        {
            Application.LoadLevel("Main_HighSchool");//メイン高校へ
        }
        if (other.gameObject.tag == "HS_h")
        {
            Application.LoadLevel("Main_HighSchool");//メイン高校へ
        }
        if (other.gameObject.tag == "HS_y")
        {
            Application.LoadLevel("Main_HighSchool");//メイン高校へ
        }




        
        //専門学校
        if (other.gameObject.tag == "Target_PS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//専門学校試験シーンへ
        }
        //専門学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "PS_s")
        {
            Application.LoadLevel("Main_ProfessionalSchool");//メイン専門学校へ
        }
        if (other.gameObject.tag == "PS_h")
        {
            Application.LoadLevel("Main_ProfessionalSchool");//メイン専門学校へ
        }
        if (other.gameObject.tag == "PS_y")
        {
            Application.LoadLevel("Main_ProfessionalSchool");//メイン専門学校へ
        }




        
        //大学
        if (other.gameObject.tag == "Target_U")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//大学試験シーンへ
        }
        //大学しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "U_s")
        {
            Application.LoadLevel("Main_College");//メイン大学へ
        }
        if (other.gameObject.tag == "U_h")
        {
            Application.LoadLevel("Main_College");//メイン大学へ
        }
        if (other.gameObject.tag == "U_y")
        {
            Application.LoadLevel("Main_College");//メイン大学へ
        }




        
        //社会人
        if (other.gameObject.tag == "Target_MOS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/S_shiken", "");//社会人試験シーンへ
        }
        //社会人しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "MOS")
        {
            Application.LoadLevel("Main_Society");//メイン社会人へ
        }




 
        //年寄り
        if (other.gameObject.tag == "Target_GA")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//年寄り試験シーンへ
        }
        //年寄りしょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "GA")
        {
            Application.LoadLevel("Main_GA");//メイン年寄りへ
        }
    }

    

}

