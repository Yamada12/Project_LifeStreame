using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

public class World_Spawner : MonoBehaviour {

    public GameObject Player;
    public float progress;//進行度
    public int examination;

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
    void Start()
    {


        //PlayerStatus.GetConverter();//Jokerから変数を受け取る
        //PlayerStatus.initStatus(); //はじめから開始時にすべての変数をリセットするメソッド

        if (StatusManager.variable.get("f.test") == "null")
        {
            examination = 0;
            StatusManager.variable.set("f.test", ((int)examination).ToString());
        }


        if (StatusManager.variable.get("f.test") != "null") //シーン開始時、nullのため
        {
            examination = int.Parse(StatusManager.variable.get("f.test"));
        }

        if (progress == 1)
        {
            if (examination >= 1)//試験後か判断　1以上で試験後
            {
                Player.transform.position = (spawner_ES.position);//試験後、小学校にスポーン
            }
        }
        if (progress == 2)
        {
            if (examination >= 1)
            {
                Player.transform.position = (spawner_JHS.position);
            }
        }

        if (progress == 3)
        {
            if (examination >= 1)
            {
                Player.transform.position = (spawner_HS.position);
            }
        }

        if (progress == 4)
        {
            if (examination >= 1)
            {
                Player.transform.position = (spawner_PS.position);
            }
        }

        if (progress == 5)
        {
            if (examination >= 1)
            {
                Player.transform.position = (spawner_U.position);
            }
        }

        if (progress == 6)
        {
            if (examination >= 1)
            {
                Player.transform.position = (spawner_MOS.position);
            }
        }

        if (progress == 7)
        {
            if (examination >= 1)
            {
                Player.transform.position = (spawner_GA.position);
            }
        }



        if (examination == 0)
        {
            if (progress == 1)
            {
                Player.transform.position = (spawner_ElementarySchool.position);//小学校前にスポーン
            }

            if (progress == 2)
            {
                Player.transform.position = (spawner_JuniorHighSchool.position);//中学校前にスポーン
            }

            if (progress == 3)
            {
                Instantiate(Player, spawner_HighSchool.position, spawner_HighSchool.rotation);//高校前にスポーン
            }

            if (progress == 4)
            {
                Instantiate(Player, spawner_ProfessionalSchool.position, spawner_ProfessionalSchool.rotation);//専門学校前にスポーン
            }

            if (progress == 5)
            {
                Instantiate(Player, spawner_University.position, spawner_University.rotation);//大学前にスポーン
            }

            if (progress == 6)
            {
                Instantiate(Player, spawner_MemberOfSociety.position, spawner_MemberOfSociety.rotation);//社会人前にスポーン
            }

            if (progress == 7)
            {
                Instantiate(Player, spawner_GoldenAger.position, spawner_GoldenAger.rotation);//年寄り前にスポーン
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
