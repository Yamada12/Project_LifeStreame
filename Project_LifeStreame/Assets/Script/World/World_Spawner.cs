using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　player01がスタートする位置を判定するスクリプト
/// 空オブジェクト　Spawner_Scriptにアタッチ
/// </summary>

public class World_Spawner : MonoBehaviour {

    public GameObject Player;
    public int progress;//デバック用の変数
    static public int examination;

    public Transform spawner_ElementarySchool;//小学校

    public Transform spawner_JuniorHighSchool;//中学校

    public Transform spawner_HighSchool;//高校

    public Transform spawner_ProfessionalSchool;//専門学校

    public Transform spawner_University;//大学

    public Transform spawner_MemberOfSociety;//社会人

    public Transform spawner_GoldenAger;//年寄り


    public Transform spawner_ES;//試験後、小学校にスポーン

    public Transform spawner_JHS;//試験後、中学校にスポーン

    public Transform spawner_HS;//試験後、高校にスポーン

    public Transform spawner_PS;//試験後、専門学校にスポーン

    public Transform spawner_U;//試験後、大学にスポーン

    public Transform spawner_MOS;//試験後、社会人にスポーン

    public Transform spawner_GA;//試験後、年寄りにスポーン


    // Use this for initialization
    void Start()//進行度によってスタート位置を判定する
    {
        //PlayerStatus.initStatus(); //はじめから開始時にすべての変数をリセットするメソッド
        //PlayerStatus.GetConverter();//Jokerから変数を受け取る
        //PlayerStatus.InitConverter();//Jokerに変数を受け渡す

        if (StatusManager.variable.get("f.test") == "null")//シーン開始時、nullのため
        {
            examination = 0;
            StatusManager.variable.set("f.test", ((int)examination).ToString());
        }
        if (StatusManager.variable.get("f.test") != "null")//試験後、値代入
        {
            examination = int.Parse(StatusManager.variable.get("f.test"));
        }


        //
        if (/*PlayerStatus.*/progress == 1)//小学校
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_ES.position);//試験後、小学校にスポーン
            }
        }
        if (/*PlayerStatus.*/progress == 2)//中学校
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_JHS.position);//試験後、小学校にスポーン
            }
        }

        if (/*PlayerStatus.*/progress == 3)//高校
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_HS.position);//試験後、小学校にスポーン
            }
        }

        if (/*PlayerStatus.*/progress == 4)//専門学校
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_PS.position);//試験後、小学校にスポーン
            }
        }

        if (/*PlayerStatus.*/progress == 5)//大学
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_U.position);//試験後、小学校にスポーン
            }
        }

        if (/*PlayerStatus.*/progress == 6)//専門学校
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_MOS.position);//試験後、小学校にスポーン
            }
        }

        if (/*PlayerStatus.*/progress == 7)//大学
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_GA.position);//試験後、小学校にスポーン
            }
        }


        //
        if (examination == 0)//試験前
        {
            if (/*PlayerStatus.*/progress == 1)
            {
                Player.transform.position = (spawner_ElementarySchool.position);//小学校前にスポーン
            }

            if (/*PlayerStatus.*/progress == 2)
            {
                Player.transform.position = (spawner_JuniorHighSchool.position);//中学校前にスポーン
            }

            if (/*PlayerStatus.*/progress == 3)
            {
                Player.transform.position = (spawner_HighSchool.position);//高校前にスポーン
            }

            if (/*PlayerStatus.*/progress == 4)
            {
                Player.transform.position = (spawner_ProfessionalSchool.position);//専門学校前にスポーン
            }

            if (/*PlayerStatus.*/progress == 5)
            {
                Player.transform.position = (spawner_University.position);//大学前にスポーン
            }

            if (/*PlayerStatus.*/progress == 6)
            {
                Player.transform.position = (spawner_MemberOfSociety.position);//社会人前にスポーン
            }

            if (/*PlayerStatus.*/progress == 7)
            {
                Player.transform.position = (spawner_GoldenAger.position);//年寄り前にスポーン
            }
        }
    }
}
