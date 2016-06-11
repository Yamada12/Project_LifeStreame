using UnityEngine;
using System.Collections;

/// <summary>
/// Worldシーン　player01の進行度・性別によるモデル切り替えのスクリプト
/// オブジェクト　Playe01にアタッチ
/// </summary>

public class World_PlayerModel : MonoBehaviour {

    //static public int progress = 4;//デバック用変数 進行度
    //public int mf;//デバック用変数　性別

    public GameObject ES_man;//小学生＿男
    public GameObject ES_woman;//小学生＿女
    public GameObject JHS_man;//中学生＿男
    public GameObject JHS_woman;//中学生＿女
    public GameObject HS_man;//高校生＿男
    public GameObject HS_woman;//高校生＿女
    public GameObject PS_man;//専門学生＿男
    public GameObject PS_woman;//専門学生＿女
    public GameObject U_man;//大学生＿男
    public GameObject U_woman;//大学生＿女
    public GameObject MOS_man;//社会人＿男
    public GameObject MOS_woman;//社会人＿女
    public GameObject GA_man;//年寄り＿男
    public GameObject GA_woman;//年寄り＿女

	// Use this for initialization
	void Start () {//初期値　プレイヤーモデル非表示
        ES_man.SetActive(false);
        ES_woman.SetActive(false);
        JHS_man.SetActive(false);
        JHS_woman.SetActive(false);
        HS_man.SetActive(false);
        HS_woman.SetActive(false);
        PS_man.SetActive(false);
        PS_woman.SetActive(false);
        U_man.SetActive(false);
        U_woman.SetActive(false);
        MOS_man.SetActive(false);
        MOS_woman.SetActive(false);
        GA_man.SetActive(false);
        GA_woman.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerStatus.progress == 1)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    ES_man.SetActive(true);
                    break;
                case 1:
                    ES_woman.SetActive(true);
                    break;
            }
        }

        if (PlayerStatus.progress == 2)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    JHS_man.SetActive(true);
                    break;
                case 1:
                    JHS_woman.SetActive(true);
                    break;
            }
        }

        if (PlayerStatus.progress == 3 || PlayerStatus.progress == 4)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    HS_man.SetActive(true);
                    break;
                case 1:
                    HS_woman.SetActive(true);
                    break;
            }
        }

        if (PlayerStatus.progress == 5)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    PS_man.SetActive(true);
                    break;
                case 1:
                    PS_woman.SetActive(true);
                    break;
            }
        }

        if(PlayerStatus.progress == 6)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    U_man.SetActive(true);
                    break;
                case 1:
                    U_woman.SetActive(true);
                    break;
            }

        }

        if (PlayerStatus.progress == 7)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    MOS_man.SetActive(true);
                    break;
                case 1:
                    MOS_woman.SetActive(true);
                    break;
            }
        }

        if (PlayerStatus.progress == 8)
        {
            switch (PlayerStatus.mf)
            {
                case 0:
                    GA_man.SetActive(true);
                    break;
                case 1:
                    GA_woman.SetActive(true);
                    break;
            }
        }

    }
}
