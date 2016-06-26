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
                TrophySystem.TrophyAcquisition(0);
                if (PlayerPrefs.GetInt("achibmentFlag00") != 1 || PlayerPrefs.HasKey("achibmentFlag00"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 1:
                TrophySystem.TrophyAcquisition(1);
                if (PlayerPrefs.GetInt("achibmentFlag01") != 1 || PlayerPrefs.HasKey("achibmentFlag01"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 2:
                TrophySystem.TrophyAcquisition(2);
                if (PlayerPrefs.GetInt("achibmentFlag02") != 1 || PlayerPrefs.HasKey("achibmentFlag02"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 3:
                TrophySystem.TrophyAcquisition(3);
                if (PlayerPrefs.GetInt("achibmentFlag03") != 1 || PlayerPrefs.HasKey("achibmentFlag03"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 4:
                TrophySystem.TrophyAcquisition(4);
                if (PlayerPrefs.GetInt("achibmentFlag04") != 1 || PlayerPrefs.HasKey("achibmentFlag04"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 5:
                TrophySystem.TrophyAcquisition(5);
                if (PlayerPrefs.GetInt("achibmentFlag05") != 1 || PlayerPrefs.HasKey("achibmentFlag05"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 6:
                TrophySystem.TrophyAcquisition(6);
                if (PlayerPrefs.GetInt("achibmentFlag06") != 1 || PlayerPrefs.HasKey("achibmentFlag06"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 7:
                TrophySystem.TrophyAcquisition(7);
                if (PlayerPrefs.GetInt("achibmentFlag07") != 1 || PlayerPrefs.HasKey("achibmentFlag07"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 8:
                TrophySystem.TrophyAcquisition(8);
                if (PlayerPrefs.GetInt("achibmentFlag08") != 1 || PlayerPrefs.HasKey("achibmentFlag08"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                    break;
            case 9:
                TrophySystem.TrophyAcquisition(9);
                if (PlayerPrefs.GetInt("achibmentFlag09") != 1 || PlayerPrefs.HasKey("achibmentFlag09"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 10:
                TrophySystem.TrophyAcquisition(10);
                if (PlayerPrefs.GetInt("achibmentFlag10") != 1 || PlayerPrefs.HasKey("achibmentFlag10"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 11:
                TrophySystem.TrophyAcquisition(11);
                if (PlayerPrefs.GetInt("achibmentFlag11") != 1 || PlayerPrefs.HasKey("achibmentFlag11"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 12:
                TrophySystem.TrophyAcquisition(12);
                if (PlayerPrefs.GetInt("achibmentFlag12") != 1 || PlayerPrefs.HasKey("achibmentFlag12"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 13:
                TrophySystem.TrophyAcquisition(13);
                if (PlayerPrefs.GetInt("achibmentFlag13") != 1 || PlayerPrefs.HasKey("achibmentFlag13"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 14:
                TrophySystem.TrophyAcquisition(14);
                if (PlayerPrefs.GetInt("achibmentFlag14") != 1 || PlayerPrefs.HasKey("achibmentFlag14"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 15:
                TrophySystem.TrophyAcquisition(15);
                if (PlayerPrefs.GetInt("achibmentFlag15") != 1 || PlayerPrefs.HasKey("achibmentFlag15"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 16:
                TrophySystem.TrophyAcquisition(16);
                if (PlayerPrefs.GetInt("achibmentFlag16") != 1 || PlayerPrefs.HasKey("achibmentFlag16"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 17:
                TrophySystem.TrophyAcquisition(17);
                if (PlayerPrefs.GetInt("achibmentFlag17") != 1 || PlayerPrefs.HasKey("achibmentFlag17"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 18:
                TrophySystem.TrophyAcquisition(18);
                if (PlayerPrefs.GetInt("achibmentFlag18") != 1 || PlayerPrefs.HasKey("achibmentFlag18"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 19:
                TrophySystem.TrophyAcquisition(19);
                if (PlayerPrefs.GetInt("achibmentFlag19") != 1 || PlayerPrefs.HasKey("achibmentFlag19"))
                {
                    moveImage.SetActive(true);
                    moveFlag = true;
                }
                break;
            case 20:
                TrophySystem.TrophyAcquisition(20);
                if (PlayerPrefs.GetInt("achibmentFlag20") != 1 || PlayerPrefs.HasKey("achibmentFlag20"))
                {
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
        }
    }
}
