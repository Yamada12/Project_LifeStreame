using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　Player01の移動先を判定するスクリプト　試験語
///　オブジェクト　Player01にアタッチ
/// </summary>

public class World_Player_After : MonoBehaviour {

    public int progress;//デバック用の変数


    //試験後　ターニング
    public Transform ES_turning;
    public Transform JHS_turning;
    public Transform HS_turning;
    public Transform PS_turning;
    public Transform U_turning;
    public Transform MOS_turning;
    public Transform GA_turning;

    //試験後、結果によって進む場所判定
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

    public Transform target_MOS;//ビル

    public Transform target_GA;//民家
	
	// Update is called once per frame
	void Update () {

        if (World_Player.result >= 1)
        {
            if (/*PlayerStatus.*/progress == 1)//小学校
            {
                switch (World_Player.result)
                {
                    case 3://1受け取り　しょぼい
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                ES_turning = target_ES_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 5://1受け取り　しょぼい
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                ES_turning = target_ES_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 7://2受け取り　ふつう
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                ES_turning = target_ES_h;
                                iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 9://3受け取り　やばい
                        //position = ES_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                ES_turning = target_ES_y;
                                iTween.MoveTo(gameObject, iTween.Hash("position", ES_turning, "time", 3.0f));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 2)//中学校
            {
                switch (World_Player.result)
                {
                    case 3://1受け取り　しょぼい
                        //position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                JHS_turning = target_JHS_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 5://1受け取り　しょぼい
                        //position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                JHS_turning = target_JHS_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 7://2受け取り　ふつう
                        //position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                JHS_turning = target_JHS_h;
                                iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 9://3受け取り　やばい
                        //position = JHS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                JHS_turning = target_JHS_y;
                                iTween.MoveTo(gameObject, iTween.Hash("position", JHS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 3)//高校
            {
                switch (World_Player.result)
                {
                    case 3://1受け取り　しょぼい
                        //position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                HS_turning = target_HS_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 5://1受け取り　しょぼい
                        //position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                HS_turning = target_HS_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 7://2受け取り　ふつう
                        //position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                HS_turning = target_HS_h;
                                iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 9://3受け取り　やばい
                        //position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                HS_turning = target_HS_y;
                                iTween.MoveTo(gameObject, iTween.Hash("position", HS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 4)//専門学校
            {
                switch (World_Player.result)
                {
                    case 3://1受け取り　しょぼい
                        //position = HS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                PS_turning = target_PS_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 5://1受け取り　しょぼい
                        //position = PS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                PS_turning = target_PS_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 7://2受け取り　ふつう
                        //position = PS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                PS_turning = target_PS_h;
                                iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 9://3受け取り　やばい
                        //position = PS_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                PS_turning = target_PS_y;
                                iTween.MoveTo(gameObject, iTween.Hash("position", PS_turning, "time", 3.0f));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 5)//大学
            {
                switch (World_Player.result)
                {
                    case 3://1受け取り　しょぼい
                        //position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                U_turning = target_U_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 5://1受け取り　しょぼい
                        //position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                U_turning = target_U_s;
                                iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 7://2受け取り　ふつう
                        //position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                U_turning = target_U_h;
                                iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                            }
                        }
                        break;
                    case 9://3受け取り　やばい
                        //position = U_turning;
                        iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                        if (World_Player.UI02 == 1)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                U_turning = target_U_y;
                                iTween.MoveTo(gameObject, iTween.Hash("position", U_turning, "time", 3.0f));
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            if (/*PlayerStatus.*/progress == 6)//社会人
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", MOS_turning, "time", 3.0f));
                if (World_Player.UI02 == 1)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        MOS_turning = target_MOS;
                        iTween.MoveTo(gameObject, iTween.Hash("position", MOS_turning, "time", 3.0f));
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 7)//年寄り
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", GA_turning, "time", 3.0f));
                if (World_Player.UI02 == 1)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        GA_turning = target_GA;
                        iTween.MoveTo(gameObject, iTween.Hash("position", GA_turning, "time", 3.0f));
                    }
                }
            }
        }

    }
}
