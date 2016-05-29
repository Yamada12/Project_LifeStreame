using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　Player01の移動先を判定するスクリプト　試験前
///　オブジェクト　Player01にアタッチ
/// </summary>

public class World_Player_Before : MonoBehaviour {

    public int progress;//デバック用の変数


    //試験前　試験シーンへ遷移するポジション　
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
    
	
	// Update is called once per frame
	void Update () {

        if (World_Player.result == 0)//試験前
        {
            if (/*PlayerStatus.*/progress == 1)
            {
                //position = turning_ES;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_ES, "time", 5.0f));//ターニング小学校までレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_ES = target_ElementarySchool;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_ES, "time", 2.0f));
                        }
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 2)
            {
                //position = turning_JHS;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_JHS, "time", 5.0f));//ターニング中学校までレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_JHS = target_JuniorHighSchool;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_JHS, "time", 2.0f));
                        }
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 3)
            {
                //position = turning_HS;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_HS, "time", 5.0f));//ターニング高校までレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_HS = target_HighSchool;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_HS, "time", 2.0f));
                        }
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 4)
            {
                //position = turning_PS;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_PS, "time", 5.0f));//ターニング専門学校までレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_PS = target_ProfessionalSchool;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_PS, "time", 2.0f));
                        }
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 5)
            {
                //position = turning_U;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_U, "time", 5.0f));//ターニング大学までレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_U = target_University;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_U, "time", 2.0f));
                        }
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 6)
            {
                //position = turning_MOS;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_MOS, "time", 5.0f));//ターニング社会人までレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_MOS = target_MemberOfSociety;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_MOS, "time", 2.0f));
                        }
                    }
                }
            }

            if (/*PlayerStatus.*/progress == 7)
            {
                //position = turning_GA;
                if (World_Player.Spawner == 1)
                {
                    iTween.MoveTo(gameObject, iTween.Hash("position", turning_GA, "time", 5.0f));//ターニング年寄りまでレッツゴー
                    if (World_Player.UI01 == 1)
                    {
                        if (Input.GetMouseButton(0))
                        {
                            turning_GA = target_GoldenAger;
                            iTween.MoveTo(gameObject, iTween.Hash("position", turning_GA, "time", 2.0f));
                        }
                    }
                }
            }
        }

    }
}
