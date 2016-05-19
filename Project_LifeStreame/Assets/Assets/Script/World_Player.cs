using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

public class World_Player : MonoBehaviour {


    public float progress;//進行度
    public int result;

    public Transform target_ElementarySchool;//小学校ポジション

    public Transform target_JuniorHighSchool;//中学校ポジション

    public Transform target_HighSchool;//高校ポジション

    public Transform target_ProfessionalSchool;//専門学校ポジション

    public Transform target_University;//大学ポジション

    public Transform target_MemberOfSociety;//社会人ポジション

    public Transform target_GoldenAger;//年寄りポジション


    public Transform target_ES_s;//小学校しょぼい

    public Transform target_ES_h;//小学校ふつう

    public Transform target_ES_y;//小学校やばい
 
    public Transform target_JHS_s;

    public Transform target_JHS_h;

    public Transform target_JHS_y;

    public Transform target_HS_s;

    public Transform target_HS_h;

    public Transform target_HS_y;

    public Transform target_PS_s;

    public Transform target_PS_h;

    public Transform target_PS_y;

    public Transform target_U_s;

    public Transform target_U_h;

    public Transform target_U_y;

    public Transform target_MOS_s;

    public Transform target_MOS_h;

    public Transform target_MOS_y;

    public Transform target_GA_s;

    public Transform target_GA_h;

    public Transform target_GA_y;

    NavMeshAgent agent;

    // Use this for initialization
    void Start() {
        agent = GetComponent<NavMeshAgent>();

        //PlayerStatus.GetConverter();//Jokerから変数を受け取る
        //PlayerStatus.initStatus(); //はじめから開始時にすべての変数をリセットするメソッド

        if (StatusManager.variable.get("f.test") == "null")
        {
            result = 0;
            StatusManager.variable.set("f.test", ((int)result).ToString());
        }

            if (StatusManager.variable.get("f.test") != "null")//シーン開始時、nullのため
        {
            result = int.Parse(StatusManager.variable.get("f.test"));
        }
        

    }

    // Update is called once per frame
    void Update() {
        if (progress == 1)//小学校
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_ES_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_ES_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_ES_y.position);
                    break;
                default:
                    break;
            }
        }

        if (progress == 2)//中学校
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_JHS_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_JHS_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_JHS_y.position);
                    break;
                default:
                    break;
            }
        }

        if (progress == 3)//高校
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_HS_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_HS_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_HS_y.position);
                    break;
                default:
                    break;
            }
        }

        if (progress == 4)//専門学校
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_PS_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_PS_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_PS_y.position);
                    break;
                default:
                    break;
            }
        }

        if (progress == 5)//大学
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_U_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_U_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_U_y.position);
                    break;
                default:
                    break;
            }
        }

        if (progress == 6)//社会人
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_MOS_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_MOS_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_MOS_y.position);
                    break;
                default:
                    break;
            }
        }

        if (progress == 7)//年寄り
        {
            switch (result)
            {
                case 1://1受け取り　しょぼい
                    agent.SetDestination(target_GA_s.position);
                    break;
                case 2://2受け取り　ふつう
                    agent.SetDestination(target_GA_h.position);
                    break;
                case 3://3受け取り　やばい
                    agent.SetDestination(target_GA_y.position);
                    break;
                default:
                    break;
            }
        }


        if (result == 0)
        {
            if (progress == 1)
            {
                agent.SetDestination(target_ElementarySchool.position);//小学校までレッツゴー
            }

            if (progress == 2)
            {
                agent.SetDestination(target_JuniorHighSchool.position);//中学校までレッツゴー
            }

            if (progress == 3)
            {
                agent.SetDestination(target_HighSchool.position);//高校までレッツゴー
            }

            if (progress == 4)
            {
                agent.SetDestination(target_ProfessionalSchool.position);//専門学校までレッツゴー
            }

            if (progress == 5)
            {
                agent.SetDestination(target_University.position);//大学までレッツゴー
            }

            if (progress == 6)
            {
                agent.SetDestination(target_MemberOfSociety.position);//社会人までレッツゴー
            }

            if (progress == 7)
            {
                agent.SetDestination(target_GoldenAger.position);//年寄りまでレッツゴー
            }
        }


    }

    public void OnTriggerEnter(Collider other)
    {
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




        /*
        //小学校
        if (other.gameObject.tag == "Target_ES")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "ES_s")
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





        //小学校
        if (other.gameObject.tag == "Target_ES")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "ES_s")
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





        //小学校
        if (other.gameObject.tag == "Target_ES")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "ES_s")
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





        //小学校
        if (other.gameObject.tag == "Target_ES")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "ES_s")
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





        //小学校
        if (other.gameObject.tag == "Target_ES")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "ES_s")
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





        //小学校
        if (other.gameObject.tag == "Target_ES")
        {

            NovelSingleton.StatusManager.callJoker("wide/Syogaku/test", "");//小学校試験シーンへ
        }
        //小学校しょぼい・ふつう・やばいにレッツゴー
        if (other.gameObject.tag == "ES_s")
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
        }*/
    }

    

}

