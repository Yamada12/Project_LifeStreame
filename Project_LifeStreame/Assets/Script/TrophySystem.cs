using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrophySystem : MonoBehaviour
{
    static public bool achibmentFlag00;     //トロフィー取得フラグ
    static public bool achibmentFlag01;     //トロフィー取得フラグ
    static public bool achibmentFlag02;     //トロフィー取得フラグ
    static public bool achibmentFlag03;     //トロフィー取得フラグ
    static public bool achibmentFlag04;     //トロフィー取得フラグ
    static public bool achibmentFlag05;     //トロフィー取得フラグ
    static public bool achibmentFlag06;     //トロフィー取得フラグ
    static public bool achibmentFlag07;     //トロフィー取得フラグ
    static public bool achibmentFlag08;     //トロフィー取得フラグ
    static public bool achibmentFlag09;     //トロフィー取得フラグ
    static public bool achibmentFlag10;     //トロフィー取得フラグ
    static public bool achibmentFlag11;     //トロフィー取得フラグ
    static public bool achibmentFlag12;     //トロフィー取得フラグ
    static public bool achibmentFlag13;     //トロフィー取得フラグ
    static public bool achibmentFlag14;     //トロフィー取得フラグ
    static public bool achibmentFlag15;     //トロフィー取得フラグ
    static public bool achibmentFlag16;     //トロフィー取得フラグ
    static public bool achibmentFlag17;     //トロフィー取得フラグ
    static public bool achibmentFlag18;     //トロフィー取得フラグ
    static public bool achibmentFlag19;     //トロフィー取得フラグ
    static public bool achibmentFlag20;     //トロフィー取得フラグ

    public GameObject[] achibmentButtons;   //トロフィーボタン
    public Sprite acquisitionImage;         //トロフィー取得後のイメージ
    public Sprite unAcquiredImage;          //トロフィー取得前のイメージ

    private GameObject evertImage;          //裏返すイメージ
    private GameObject hiddenlement;        //アナグラムテキストの背景
    private Text trophyNameText;            //トロフィーの名前
    private Text conditionText;             //取得条件
    private Text detailText;                //詳細
    private Text anagramText;               //アナグラムテキスト

    private bool before = true;

    // Use this for initialization
    void Start()
    {
        evertImage = GameObject.Find("EvertImage");
        hiddenlement = GameObject.Find("HiddenImage");
        trophyNameText = GameObject.Find("Name").GetComponent<Text>();
        conditionText = GameObject.Find("Conditions").GetComponent<Text>();
        detailText = GameObject.Find("Detail").GetComponent<Text>();
        anagramText = GameObject.Find("HiddenElement").GetComponent<Text>(); 

        hiddenlement.transform.FindChild("HiddenElement").gameObject.SetActive(false);
        CheckAchibment();
    }

    /// <summary>
    /// トロフィーの詳細画面を裏返す
    /// </summary>
    public void EvertTrophy()
    {
        if (before)
        {
            before = false;
            iTween.RotateTo(evertImage, iTween.Hash("y", 180f, "time", 2f));
            iTween.RotateTo(hiddenlement, iTween.Hash("y", 360f, "time", 2f));
            hiddenlement.transform.FindChild("HiddenElement").gameObject.SetActive(true);
            trophyNameText.gameObject.SetActive(false);
            conditionText.gameObject.SetActive(false);
            detailText.gameObject.SetActive(false);
        }
        else
        {
            before = true;
            iTween.RotateTo(evertImage, iTween.Hash("y", 360f, "time", 2f));
            iTween.RotateTo(hiddenlement, iTween.Hash("y", 180f, "time", 2f));
            hiddenlement.transform.FindChild("HiddenElement").gameObject.SetActive(false);
            trophyNameText.gameObject.SetActive(true);
            conditionText.gameObject.SetActive(true);
            detailText.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// トロフィーの取得状況を確認してボタンのイメージを変更するメソッド
    /// </summary>
    public void CheckAchibment()
    {
        LoadTrophy();
        if (achibmentFlag00)//------------------------------------------------------------------------
            achibmentButtons[0].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[0].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag01)//------------------------------------------------------------------------
            achibmentButtons[1].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[1].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag02)//------------------------------------------------------------------------
            achibmentButtons[2].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[2].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag03)//------------------------------------------------------------------------
            achibmentButtons[3].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[3].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag04)//------------------------------------------------------------------------
            achibmentButtons[4].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[4].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag05)//------------------------------------------------------------------------
            achibmentButtons[5].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[5].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag06)//------------------------------------------------------------------------
            achibmentButtons[6].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[6].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag07)//------------------------------------------------------------------------
            achibmentButtons[7].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[7].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag08)//------------------------------------------------------------------------
            achibmentButtons[8].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[8].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag09)//------------------------------------------------------------------------
            achibmentButtons[9].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[9].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag10)//------------------------------------------------------------------------
            achibmentButtons[10].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[10].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag11)//------------------------------------------------------------------------
            achibmentButtons[11].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[11].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag12)//------------------------------------------------------------------------
            achibmentButtons[12].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[12].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag13)//------------------------------------------------------------------------
            achibmentButtons[13].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[13].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag14)//------------------------------------------------------------------------
            achibmentButtons[14].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[14].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag15)//------------------------------------------------------------------------
            achibmentButtons[15].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[15].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag16)//------------------------------------------------------------------------
            achibmentButtons[16].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[16].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag17)//------------------------------------------------------------------------
            achibmentButtons[17].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[17].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag18)//------------------------------------------------------------------------
            achibmentButtons[18].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[18].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag19)//------------------------------------------------------------------------
            achibmentButtons[19].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[19].GetComponent<Button>().image.sprite = unAcquiredImage;

        if (achibmentFlag20)//------------------------------------------------------------------------
            achibmentButtons[20].GetComponent<Button>().image.sprite = acquisitionImage;
        else
            achibmentButtons[20].GetComponent<Button>().image.sprite = unAcquiredImage;

    }

    /// <summary>
    /// トロフィーの詳細を確認する
    /// </summary>
    /// <param name="id"></param>
    public void showDetail(int id)
    {
        switch(id)
        {
            case 0:
                if (achibmentFlag00)
                {
                    trophyNameText.text = "菩薩級コミュニティ";
                    conditionText.text = "コミュ力をカンストする。";
                    detailText.text = "君は菩薩級のコミュ力を持っているようだね。\nこれからもそのありあまるコミュ力を酷使するといいよ";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "コミュ力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 1:
                if (achibmentFlag01)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 2:
                if (achibmentFlag02)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 3:
                if (achibmentFlag03)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 4:
                if (achibmentFlag04)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 5:
                if (achibmentFlag05)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 6:
                if (achibmentFlag06)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 7:
                if (achibmentFlag07)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 8:
                if (achibmentFlag08)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 9:
                if (achibmentFlag09)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 10:
                if (achibmentFlag10)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 11:
                if (achibmentFlag11)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 12:
                if (achibmentFlag12)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 13:
                if (achibmentFlag13)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 14:
                if (achibmentFlag14)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 15:
                if (achibmentFlag15)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 16:
                if (achibmentFlag16)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 17:
                if (achibmentFlag17)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 18:
                if (achibmentFlag18)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 19:
                if (achibmentFlag19)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            case 20:
                if (achibmentFlag20)
                {
                    trophyNameText.text = "ありあまる資産";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "君は底知れない経済力を持っているようだね。\nその膨大な資産を一体何に使うんだい？";
                    anagramText.text = "はっぴはっぴ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力をカンストする。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "はっぴはっぴ";
                }
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// トロフィー取得メソッド
    /// </summary>
    /// <param name="id">取得したトロフィーのID</param>
    static public void TrophyAcquisition(int id)
    {
        switch (id)
        {
            case 0:
                achibmentFlag00 = true;
                PlayerPrefs.SetInt("achibmentFlag00", 1);
                break;
            case 1:
                achibmentFlag01 = true;
                PlayerPrefs.SetInt("achibmentFlag01", 1);
                break;
            case 2:
                achibmentFlag02 = true;
                PlayerPrefs.SetInt("achibmentFlag02", 1);
                break;
            case 3:
                achibmentFlag03 = true;
                PlayerPrefs.SetInt("achibmentFlag03", 1);
                break;
            case 4:
                achibmentFlag04 = true;
                PlayerPrefs.SetInt("achibmentFlag05", 1);
                break;
            case 5:
                achibmentFlag05 = true;
                PlayerPrefs.SetInt("achibmentFlag05", 1);
                break;
            case 6:
                achibmentFlag06 = true;
                PlayerPrefs.SetInt("achibmentFlag06", 1);
                break;
            case 7:
                achibmentFlag07 = true;
                PlayerPrefs.SetInt("achibmentFlag07", 1);
                break;
            case 8:
                achibmentFlag08 = true;
                PlayerPrefs.SetInt("achibmentFlag08", 1);
                break;
            case 9:
                achibmentFlag09 = true;
                PlayerPrefs.SetInt("achibmentFlag09", 1);
                break;
            case 10:
                achibmentFlag10 = true;
                PlayerPrefs.SetInt("achibmentFlag10", 1);
                break;
            case 11:
                achibmentFlag11 = true;
                PlayerPrefs.SetInt("achibmentFlag11", 1);
                break;
            case 12:
                achibmentFlag12 = true;
                PlayerPrefs.SetInt("achibmentFlag12", 1);
                break;
            case 13:
                achibmentFlag13 = true;
                PlayerPrefs.SetInt("achibmentFlag13", 1);
                break;
            case 14:
                achibmentFlag14 = true;
                PlayerPrefs.SetInt("achibmentFlag14", 1);
                break;
            case 15:
                achibmentFlag15 = true;
                PlayerPrefs.SetInt("achibmentFlag15", 1);
                break;
            case 16:
                achibmentFlag16 = true;
                PlayerPrefs.SetInt("achibmentFlag16", 1);
                break;
            case 17:
                achibmentFlag17 = true;
                PlayerPrefs.SetInt("achibmentFlag17", 1);
                break;
            case 18:
                achibmentFlag18 = true;
                PlayerPrefs.SetInt("achibmentFlag18", 1);
                break;
            case 19:
                achibmentFlag19 = true;
                PlayerPrefs.SetInt("achibmentFlag19", 1);
                break;
            case 20:
                achibmentFlag20 = true;
                PlayerPrefs.SetInt("achibmentFlag20", 1);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 取得したトロフィーをロードする
    /// </summary>
    void LoadTrophy()
    {
        if (PlayerPrefs.GetInt("achibmentFlag00") == 1)//----------------------------------
            achibmentFlag00 = true;
        else
            achibmentFlag00 = false;

        if (PlayerPrefs.GetInt("achibmentFlag01") == 1)//----------------------------------
            achibmentFlag01 = true;
        else
            achibmentFlag01 = false;

        if (PlayerPrefs.GetInt("achibmentFlag02") == 1)//----------------------------------
            achibmentFlag02 = true;
        else
            achibmentFlag02 = false;

        if (PlayerPrefs.GetInt("achibmentFlag03") == 1)//----------------------------------
            achibmentFlag03 = true;
        else
            achibmentFlag03 = false;

        if (PlayerPrefs.GetInt("achibmentFlag04") == 1)//----------------------------------
            achibmentFlag04 = true;
        else
            achibmentFlag04 = false;

        if (PlayerPrefs.GetInt("achibmentFlag05") == 1)//----------------------------------
            achibmentFlag05 = true;
        else
            achibmentFlag05 = false;

        if (PlayerPrefs.GetInt("achibmentFlag06") == 1)//----------------------------------
            achibmentFlag06 = true;
        else
            achibmentFlag06 = false;

        if (PlayerPrefs.GetInt("achibmentFlag07") == 1)//----------------------------------
            achibmentFlag07 = true;
        else
            achibmentFlag07 = false;

        if (PlayerPrefs.GetInt("achibmentFlag08") == 1)//----------------------------------
            achibmentFlag08 = true;
        else
            achibmentFlag08 = false;

        if (PlayerPrefs.GetInt("achibmentFlag09") == 1)//----------------------------------
            achibmentFlag09 = true;
        else
            achibmentFlag09 = false;

        if (PlayerPrefs.GetInt("achibmentFlag10") == 1)//----------------------------------
            achibmentFlag10 = true;
        else
            achibmentFlag10 = false;

        if (PlayerPrefs.GetInt("achibmentFlag11") == 1)//----------------------------------
            achibmentFlag11 = true;
        else
            achibmentFlag11 = false;

        if (PlayerPrefs.GetInt("achibmentFlag12") == 1)//----------------------------------
            achibmentFlag12 = true;
        else
            achibmentFlag12 = false;

        if (PlayerPrefs.GetInt("achibmentFlag13") == 1)//----------------------------------
            achibmentFlag13 = true;
        else
            achibmentFlag13 = false;

        if (PlayerPrefs.GetInt("achibmentFlag14") == 1)//----------------------------------
            achibmentFlag14 = true;
        else
            achibmentFlag14 = false;

        if (PlayerPrefs.GetInt("achibmentFlag15") == 1)//----------------------------------
            achibmentFlag15 = true;
        else
            achibmentFlag15 = false;

        if (PlayerPrefs.GetInt("achibmentFlag16") == 1)//----------------------------------
            achibmentFlag16 = true;
        else
            achibmentFlag16 = false;

        if (PlayerPrefs.GetInt("achibmentFlag17") == 1)//----------------------------------
            achibmentFlag17 = true;
        else
            achibmentFlag17 = false;

        if (PlayerPrefs.GetInt("achibmentFlag18") == 1)//----------------------------------
            achibmentFlag18 = true;
        else
            achibmentFlag18 = false;

        if (PlayerPrefs.GetInt("achibmentFlag19") == 1)//----------------------------------
            achibmentFlag19 = true;
        else
            achibmentFlag19 = false;

        if (PlayerPrefs.GetInt("achibmentFlag20") == 1)//----------------------------------
            achibmentFlag20 = true;
        else
            achibmentFlag20 = false;
    }
}
