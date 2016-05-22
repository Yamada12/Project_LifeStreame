using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

public class World_Player : MonoBehaviour {

    public int progress;//デバック用の変数
    public int result;
    private Transform position;
    static public int UI01;
    static public int UI02;

    public Transform target_ElementarySchool;//小学校ポジション

    public Transform target_JuniorHighSchool;//中学校ポジション

    public Transform target_HighSchool;//高校ポジション

    public Transform target_ProfessionalSchool;//専門学校ポジション

    public Transform target_University;//大学ポジション

    public Transform target_MemberOfSociety;//社会人ポジション

    public Transform target_GoldenAger;//年寄りポジション

    //試験前　ターニング
    public Transform turning_ES;

    public Transform turning_JHS;

    public Transform turning_HS;

    public Transform turning_PS;

    public Transform turning_U;

    public Transform turning_MOS;

    public Transform turning_GA;

    //試験後　ターニング
    public Transform ES_turning;

    public Transform JHS_turning;

    public Transform HS_turning;

    public Transform PS_turning;

    public Transform U_turning;

    public Transform MOS_turning;

    public Transform GA_turning;


    public Transform target_ES_s;//小学校しょぼい

    public Transform target_ES_h;//小学校ふつう

    public Transform target_ES_y;//小学校やばい
 
    public Transform target_JHS_s;//中学校しょぼい

    public Transform target_JHS_h;//中学校ふつう

    public Transform target_JHS_y;//中学校やばい

    public Transform target_HS_s;//高校しょぼい

    public Transform target_HS_h;//高校ふつう

    public Transform target_HS_y;//高校やばい

    public Transform target_PS_s;//専門学校しょぼい

    public Transform target_PS_h;//専門学校ふつう

    public Transform target_PS_y;//専門学校やばい

    public Transform target_U_s;//大学しょぼい

    public Transform target_U_h;//大学ふつう

    public Transform target_U_y;//大学やばい

    public Transform target_MOS_s;//社会人しょぼい

    public Transform target_MOS_h;//社会人ふつう

    public Transform target_MOS_y;//社会人やばい

    public Transform target_GA_s;//年寄りしょぼい

    public Transform target_GA_h;//年寄りふつう

    public Transform target_GA_y;//年寄りやばい

    // Use this for initialization
    void Start() {
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

    // Update is called once per frame
    void Update() {
        if (result >= 1)
        {
            if (/*PlayerStatus.*/progress == 1)//小学校
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (Input.GetMouseButtonDown(0))
                        {
                            ES_turning = target_ES_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (Input.GetMouseButtonDown(0))
                        {
                            ES_turning = target_ES_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        }
                        break;
                    case 3://3受け取り　やばい
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (Input.GetMouseButtonDown(0))
                        {
                            ES_turning = target_ES_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 2)//中学校
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_JHS_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_JHS_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 3://3受け取り　やばい
                        position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_JHS_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 3)//高校
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_HS_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_HS_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 3://3受け取り　やばい
                        position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_HS_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 4)//専門学校
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        position = PS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_PS_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        position = PS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_PS_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 3://3受け取り　やばい
                        position = PS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_PS_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 5)//大学
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_U_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_U_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 3://3受け取り　やばい
                        position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_U_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 6)//社会人
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        position = MOS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_MOS_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        position = MOS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_MOS_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 3://3受け取り　やばい
                        position = MOS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_MOS_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 7)//年寄り
            {
                switch (result)
                {
                    case 1://1受け取り　しょぼい
                        position = GA_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_GA_s;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 2://2受け取り　ふつう
                        position = GA_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_GA_h;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    case 3://3受け取り　やばい
                        position = GA_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        if (Input.GetMouseButtonDown(0))
                        {
                            position = target_GA_y;
                            iTween.MoveTo(gameObject, iTween.Hash("position", position));
                        }
                        break;
                    default:
                        break;
                }
            }
        }


        //
        if (result == 0)//試験前
        {
            if (/*PlayerStatus.*/progress == 1)
            {
                //position = turning_ES;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_ES, "time", 5.0f));//ターニング小学校までレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_ES = target_ElementarySchool;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_ES, "time", 2.0f));
                }
            }

            if (/*PlayerStatus.*/progress == 2)
            {
                //position = turning_JHS;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_JHS));//ターニング中学校までレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_JHS = target_JuniorHighSchool;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_JHS));
                }
            }

            if (/*PlayerStatus.*/progress == 3)
            {
                //position = turning_HS;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_HS));//ターニング高校までレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_HS = target_HighSchool;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_HS));
                }
            }

            if (/*PlayerStatus.*/progress == 4)
            {
                //position = turning_PS;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_PS));//ターニング専門学校までレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_PS = target_ProfessionalSchool;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_PS));
                }
            }

            if (/*PlayerStatus.*/progress == 5)
            {
                //position = turning_U;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_U));//ターニング大学までレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_U = target_University;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_U));
                }
            }

            if (/*PlayerStatus.*/progress == 6)
            {
                //position = turning_MOS;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_MOS));//ターニング社会人までレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_MOS = target_MemberOfSociety;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_MOS));
                }
            }

            if (/*PlayerStatus.*/progress == 7)
            {
                //position = turning_GA;
                iTween.MoveTo(gameObject, iTween.Hash("position", turning_GA));//ターニング年寄りまでレッツゴー
                if (Input.GetMouseButton(0))
                {
                    turning_GA = target_GoldenAger;
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_GA));
                }
            }
        }
    }

    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "turning_point")
        {
            UI01 = 1;
        }
        if(other.gameObject.tag == "point_turning")
        {
            UI02 = 1;
        }


        //小学校
        if(other.gameObject.tag == "Target_ES")
        {
            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if(other.gameObject.tag == "ES_s")
        {
            Application.LoadLevel("Main_ES");//メイン小学校へ
        }
        if (other.gameObject.tag == "ES_h")
        {
            Application.LoadLevel("Main_ES");//メイン小学校へ
        }
        if (other.gameObject.tag == "ES_y")
        {
            Application.LoadLevel("Main_ES");//メイン小学校へ
        }




        
        //中学校
        if (other.gameObject.tag == "Target_JHS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//中学校試験シーンへ
        }
        //中学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "JHS_s")
        {
            Application.LoadLevel("Main_JHS");//メイン中学校へ
        }
        if (other.gameObject.tag == "JHS_h")
        {
            Application.LoadLevel("Main_JHS");//メイン中学校へ
        }
        if (other.gameObject.tag == "JHS_y")
        {
            Application.LoadLevel("Main_JHS");//メイン中学校へ
        }




        
        //高校
        if (other.gameObject.tag == "Target_HS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//高校試験シーンへ
        }
        //高校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "HS_s")
        {
            Application.LoadLevel("Main_HS");//メイン高校へ
        }
        if (other.gameObject.tag == "HS_h")
        {
            Application.LoadLevel("Main_HS");//メイン高校へ
        }
        if (other.gameObject.tag == "HS_y")
        {
            Application.LoadLevel("Main_HS");//メイン高校へ
        }




        
        //専門学校
        if (other.gameObject.tag == "Target_PS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//専門学校試験シーンへ
        }
        //専門学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "PS_s")
        {
            Application.LoadLevel("Main_PS");//メイン専門学校へ
        }
        if (other.gameObject.tag == "PS_h")
        {
            Application.LoadLevel("Main_PS");//メイン専門学校へ
        }
        if (other.gameObject.tag == "PS_y")
        {
            Application.LoadLevel("Main_PS");//メイン専門学校へ
        }




        
        //大学
        if (other.gameObject.tag == "Target_U")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//大学試験シーンへ
        }
        //大学しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "U_s")
        {
            Application.LoadLevel("Main_U");//メイン大学へ
        }
        if (other.gameObject.tag == "U_h")
        {
            Application.LoadLevel("Main_U");//メイン大学へ
        }
        if (other.gameObject.tag == "U_y")
        {
            Application.LoadLevel("Main_U");//メイン大学へ
        }




        
        //社会人
        if (other.gameObject.tag == "Target_MOS")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//社会人試験シーンへ
        }
        //社会人しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "MOS_s")
        {
            Application.LoadLevel("Main_MOS");//メイン社会人へ
        }
        if (other.gameObject.tag == "MOS_h")
        {
            Application.LoadLevel("Main_MOS");//メイン社会人へ
        }
        if (other.gameObject.tag == "MOS_y")
        {
            Application.LoadLevel("Main_MOS");//メイン社会人へ
        }




       
        //年寄り
        if (other.gameObject.tag == "Target_GA")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//年寄り試験シーンへ
        }
        //年寄りしょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "GA_s")
        {
            Application.LoadLevel("Main_GA");//メイン年寄りへ
        }
        if (other.gameObject.tag == "GA_h")
        {
            Application.LoadLevel("Main_GA");//メイン年寄りへ
        }
        if (other.gameObject.tag == "GA_y")
        {
            Application.LoadLevel("Main_GA");//メイン年寄りへ
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "turning point")
        {
            UI01 = 0;
        }
        if(other.gameObject.tag == "point_turning")
        {
            UI02 = 0;
        }
    }

    

}

