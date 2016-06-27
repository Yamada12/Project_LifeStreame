using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PopTrophy : MonoBehaviour
{
    static public GameObject trophyBasePoint;
    static public GameObject trophyBasePoint02;
    static public GameObject moveImage;
    static public Text trophyName;
    static public Text conditionText;

	// Use this for initialization
	void Start ()
    {
        trophyBasePoint = GameObject.Find("BasePointWithTrophy");
        trophyBasePoint02 = GameObject.Find("BasePointWithTrophy02");
        moveImage = GameObject.Find("PopUpImage");
        trophyName = GameObject.Find("TrophyName").GetComponent<Text>();
        conditionText = GameObject.Find("ConditionsText").GetComponent<Text>();
        StartCoroutine(TrophyGetFounder());
    }

    IEnumerator TrophyGetFounder()
    {
        if (PlayerStatus.co >= 999)
            PopTrophy.GetTrophy("コミュ力がマキシマム", "コミュ力が極まった", 0);

        if(PlayerStatus.ec >= 999)
            PopTrophy.GetTrophy("ブルジョワ", "経済力が極まった", 1);

        if(PlayerStatus.ac >= 999)
            PopTrophy.GetTrophy("生き字引", "学力が極まった", 2);

        if(PlayerStatus.hu >= 999)
            PopTrophy.GetTrophy("菩薩", "人間力が極まった", 3);

        if(PlayerStatus.vi >= 999)
            PopTrophy.GetTrophy("目指せスポコン！", "体力が極まった", 4);

        if(PlayerStatus.lu >= 999)
            PopTrophy.GetTrophy("神に愛されし者", "運が極まった", 5);

        if(PlayerStatus.co >= 999 && PlayerStatus.ec >= 999 && PlayerStatus.ac >= 999 && PlayerStatus.hu >= 999 && PlayerStatus.vi >= 999 && PlayerStatus.lu >= 999)
            PopTrophy.GetTrophy("PerfectHuman", "全能になった", 6);

        if(PlayerStatus.geneNumber >= 2)
            PopTrophy.GetTrophy("次はお前の番だ。", "世代交代を行った", 7);

        if(PlayerStatus.job == "王子・王女")
            PopTrophy.GetTrophy("世界は自分の物！", "王子・王女になった", 9);

        if(PlayerStatus.marriage == 11 && PlayerStatus.mf == 0)
            PopTrophy.GetTrophy("思い出のクレープ", "姫百合橙花と結婚した", 10);

        if (PlayerStatus.marriage == 12 && PlayerStatus.mf == 0)
            PopTrophy.GetTrophy("やきとり…", "佐倉梨沙と結婚した", 11);

        if (PlayerStatus.marriage == 13 && PlayerStatus.mf == 0)
            PopTrophy.GetTrophy("全力疾走！", "花楓蒼空と結婚した", 12);

        if (PlayerStatus.marriage == 11 && PlayerStatus.mf == 1)
            PopTrophy.GetTrophy("ただのメガネ", "羽神和真と結婚した", 13);

        if (PlayerStatus.marriage == 12 && PlayerStatus.mf == 1)
            PopTrophy.GetTrophy("腹筋崩壊！", "鎌瀬虎次郎と結婚した", 14);

        if (PlayerStatus.marriage == 13 && PlayerStatus.mf == 1)
            PopTrophy.GetTrophy("Open your Eyes！", "檜山善鷹と結婚した", 15);

        TrophySystem.LastTrophyChecker();

        if (TrophySystem.achibmentFlag20)
            StopCoroutine(TrophyGetFounder());

        yield return new WaitForSeconds(1f);//-----------------------------------------------------------------------

        if (PlayerStatus.co >= 999)
            PopTrophy.GetTrophy("コミュ力がマキシマム", "コミュ力が極まった", 0);

        if (PlayerStatus.ec >= 999)
            PopTrophy.GetTrophy("ブルジョワ", "経済力が極まった", 1);

        if (PlayerStatus.ac >= 999)
            PopTrophy.GetTrophy("生き字引", "学力が極まった", 2);

        if (PlayerStatus.hu >= 999)
            PopTrophy.GetTrophy("菩薩", "人間力が極まった", 3);

        if (PlayerStatus.vi >= 999)
            PopTrophy.GetTrophy("目指せスポコン！", "体力が極まった", 4);

        if (PlayerStatus.lu >= 999)
            PopTrophy.GetTrophy("神に愛されし者", "運が極まった", 5);

        if (PlayerStatus.co >= 999 && PlayerStatus.ec >= 999 && PlayerStatus.ac >= 999 && PlayerStatus.hu >= 999 && PlayerStatus.vi >= 999 && PlayerStatus.lu >= 999)
            PopTrophy.GetTrophy("PerfectHuman", "全能になった", 6);

        if (PlayerStatus.geneNumber >= 2)
            PopTrophy.GetTrophy("次はお前の番だ。", "世代交代を行った", 7);

        if (PlayerStatus.job == "王子・王女")
            PopTrophy.GetTrophy("世界は自分の物！", "王子・王女になった", 9);

        if (PlayerStatus.marriage == 11 && PlayerStatus.mf == 0)
            PopTrophy.GetTrophy("思い出のクレープ", "姫百合橙花と結婚した", 10);

        if (PlayerStatus.marriage == 12 && PlayerStatus.mf == 0)
            PopTrophy.GetTrophy("やきとり…", "佐倉梨沙と結婚した", 11);

        if (PlayerStatus.marriage == 13 && PlayerStatus.mf == 0)
            PopTrophy.GetTrophy("全力疾走！", "花楓蒼空と結婚した", 12);

        if (PlayerStatus.marriage == 11 && PlayerStatus.mf == 1)
            PopTrophy.GetTrophy("ただのメガネ", "羽神和真と結婚した", 13);

        if (PlayerStatus.marriage == 12 && PlayerStatus.mf == 1)
            PopTrophy.GetTrophy("腹筋崩壊！", "鎌瀬虎次郎と結婚した", 14);

        if (PlayerStatus.marriage == 13 && PlayerStatus.mf == 1)
            PopTrophy.GetTrophy("Open your Eyes！", "檜山善鷹と結婚した", 15);

        TrophySystem.LastTrophyChecker();

        if (TrophySystem.achibmentFlag20)
            StopCoroutine(TrophyGetFounder());

        StartCoroutine(TrophyGetFounder());
    }

    /// <summary>
    /// トロフィーを取得するメソッド
    /// </summary>
    /// <param name="name">取得したトロフィーの名前</param>
    /// <param name="conditionm">取得した条件</param>
    /// <param name="trophyNo">取得したトロフィーのID</param>
    static public void GetTrophy(string name, string condition, int trophyID)
    {
        trophyName.text = name;
        conditionText.text = condition;
        bool moveFlag = false;
        switch(trophyID)
        {
            case 0:
                if (PlayerPrefs.GetInt("achibmentFlag00") != 1 || !PlayerPrefs.HasKey("achibmentFlag00"))
                {
                    TrophySystem.TrophyAcquisition(0);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 1:
                if (PlayerPrefs.GetInt("achibmentFlag01") != 1 || !PlayerPrefs.HasKey("achibmentFlag01"))
                {
                    TrophySystem.TrophyAcquisition(1);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("achibmentFlag02") != 1 || !PlayerPrefs.HasKey("achibmentFlag02"))
                {
                    TrophySystem.TrophyAcquisition(2);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("achibmentFlag03") != 1 || !PlayerPrefs.HasKey("achibmentFlag03"))
                {
                    TrophySystem.TrophyAcquisition(3);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("achibmentFlag04") != 1 || !PlayerPrefs.HasKey("achibmentFlag04"))
                {
                    TrophySystem.TrophyAcquisition(4);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 5:
                if (PlayerPrefs.GetInt("achibmentFlag05") != 1 || !PlayerPrefs.HasKey("achibmentFlag05"))
                {
                    TrophySystem.TrophyAcquisition(5);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 6:
                if (PlayerPrefs.GetInt("achibmentFlag06") != 1 || !PlayerPrefs.HasKey("achibmentFlag06"))
                {
                    TrophySystem.TrophyAcquisition(6);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 7:
                if (PlayerPrefs.GetInt("achibmentFlag07") != 1 || !PlayerPrefs.HasKey("achibmentFlag07"))
                {
                    TrophySystem.TrophyAcquisition(7);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 8:
                if (PlayerPrefs.GetInt("achibmentFlag08") != 1 || !PlayerPrefs.HasKey("achibmentFlag08"))
                {
                    TrophySystem.TrophyAcquisition(8);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                    break;
            case 9:
                if (PlayerPrefs.GetInt("achibmentFlag09") != 1 || !PlayerPrefs.HasKey("achibmentFlag09"))
                {
                    TrophySystem.TrophyAcquisition(9);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 10:
                if (PlayerPrefs.GetInt("achibmentFlag10") != 1 || !PlayerPrefs.HasKey("achibmentFlag10"))
                {
                    TrophySystem.TrophyAcquisition(10);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 11:
                if (PlayerPrefs.GetInt("achibmentFlag11") != 1 || !PlayerPrefs.HasKey("achibmentFlag11"))
                {
                    TrophySystem.TrophyAcquisition(11);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 12:
                if (PlayerPrefs.GetInt("achibmentFlag12") != 1 || !PlayerPrefs.HasKey("achibmentFlag12"))
                {
                    TrophySystem.TrophyAcquisition(12);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 13:
                if (PlayerPrefs.GetInt("achibmentFlag13") != 1 || !PlayerPrefs.HasKey("achibmentFlag13"))
                {
                    TrophySystem.TrophyAcquisition(13);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 14:
                if (PlayerPrefs.GetInt("achibmentFlag14") != 1 || !PlayerPrefs.HasKey("achibmentFlag14"))
                {
                    TrophySystem.TrophyAcquisition(14);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 15:
                if (PlayerPrefs.GetInt("achibmentFlag15") != 1 || !PlayerPrefs.HasKey("achibmentFlag15"))
                {
                    TrophySystem.TrophyAcquisition(15);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 16:
                if (PlayerPrefs.GetInt("achibmentFlag16") != 1 || !PlayerPrefs.HasKey("achibmentFlag16"))
                {
                    TrophySystem.TrophyAcquisition(16);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 17:
                if (PlayerPrefs.GetInt("achibmentFlag17") != 1 || !PlayerPrefs.HasKey("achibmentFlag17"))
                {
                    TrophySystem.TrophyAcquisition(17);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 18:
                if (PlayerPrefs.GetInt("achibmentFlag18") != 1 || !PlayerPrefs.HasKey("achibmentFlag18"))
                {
                    TrophySystem.TrophyAcquisition(18);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 19:
                if (PlayerPrefs.GetInt("achibmentFlag19") != 1 || !PlayerPrefs.HasKey("achibmentFlag19"))
                {
                    TrophySystem.TrophyAcquisition(19);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 20:
                if (PlayerPrefs.GetInt("achibmentFlag20") != 1 || !PlayerPrefs.HasKey("achibmentFlag20"))
                {
                    TrophySystem.TrophyAcquisition(20);
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            default:
                break;
        }
        if(moveFlag)
        {
            iTween.MoveTo(moveImage, iTween.Hash("position", trophyBasePoint02.transform.position, "time", 2f));
            iTween.MoveTo(moveImage, iTween.Hash("position", trophyBasePoint.transform.position, "time", 2f, "delay", 4f));
            moveFlag = false;
        }
    }

    public void closeTrophy()
    {
        iTween.MoveTo(moveImage, iTween.Hash("position", trophyBasePoint.transform.position, "time", 1f));
    }
}
