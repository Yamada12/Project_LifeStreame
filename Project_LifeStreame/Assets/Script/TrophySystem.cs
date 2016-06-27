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
        SoundPlayer.Instance.PlayBGM("Work");
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
                    trophyNameText.text = "コミュ力がマキシマム";
                    conditionText.text = "コミュ力を極める。";
                    detailText.text = "視界に入ったものはみんな友達！";
                    anagramText.text = "俺にコミュ力なんてなかった…";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "コミュ力を極める。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 1:
                if (achibmentFlag01)
                {
                    trophyNameText.text = "ブルジョワ";
                    conditionText.text = "経済力を極める。";
                    detailText.text = "世の中お金なんだよー！！";
                    anagramText.text = "お金が欲しい…";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "経済力を極める。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 2:
                if (achibmentFlag02)
                {
                    trophyNameText.text = "生き字引";
                    conditionText.text = "学力を極める。";
                    detailText.text = "99%の努力と1%の運";
                    anagramText.text = "バカでも人生は楽しいと思っていた";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "学力を極める。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 3:
                if (achibmentFlag03)
                {
                    trophyNameText.text = "菩薩";
                    conditionText.text = "人間力を極める。";
                    detailText.text = "人間の域を超えた人間力";
                    anagramText.text = "人間力のある奴に嫉妬した";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "人間力を極める。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 4:
                if (achibmentFlag04)
                {
                    trophyNameText.text = "目指せスポコン！";
                    conditionText.text = "体力を極める。";
                    detailText.text = "スポコンまであと一歩";
                    anagramText.text = "運動が出来たら楽しかっただろうな";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "体力を極める。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 5:
                if (achibmentFlag05)
                {
                    trophyNameText.text = "神に愛されし者";
                    conditionText.text = "運を極める。";
                    detailText.text = "99%の運と1%のひらめき";
                    anagramText.text = "運に頼っていた…";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "運を極める。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 6:
                if (achibmentFlag06)
                {
                    trophyNameText.text = "PerfectHuman";
                    conditionText.text = "全能の力を手に入れる。";
                    detailText.text = "You are a perfect human!";
                    anagramText.text = "俺は底辺の人間だ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "神になる";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 7:
                if (achibmentFlag07)
                {
                    trophyNameText.text = "次はお前の番だ。";
                    conditionText.text = "世代交代をする。";
                    detailText.text = "一家の人生は一人だけのものじゃない！";
                    anagramText.text = "俺にどうしろっていうんだ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "次世代に願いを託す";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 8:
                if (achibmentFlag08)
                {
                    trophyNameText.text = "はっぴはっぴー！";
                    conditionText.text = "はっぴはっぴを捕まえた。";
                    detailText.text = "これで君もはっぴはっぴー！";
                    anagramText.text = "そして、そいつは現れた";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "妖精を捕まえる";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 9:
                if (achibmentFlag09)
                {
                    trophyNameText.text = "世界は自分の物！";
                    conditionText.text = "王子。王女になった。";
                    detailText.text = "世界は一言で動かせる";
                    anagramText.text = "妄想か現実かわからない";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "世界を手に入れられる職に就く。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 10:
                if (achibmentFlag10)
                {
                    trophyNameText.text = "思いでのクレープ";
                    conditionText.text = "姫百合橙花と結婚した。";
                    detailText.text = "クレープとあんたは私のもの！！";
                    anagramText.text = "あはは…今日はデートでクレープを食べたよ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "つんつんデレデレ";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 11:
                if (achibmentFlag11)
                {
                    trophyNameText.text = "やきとり…";
                    conditionText.text = "佐倉梨沙と結婚した。";
                    detailText.text = "やきとりぃー！やきとりがいーいーっ！";
                    anagramText.text = "本当は好きなんだよね？…焼き鳥";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "雰囲気的にアウトよ。";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 12:
                if (achibmentFlag12)
                {
                    trophyNameText.text = "全力疾走！";
                    conditionText.text = "花楓蒼空と結婚した。";
                    detailText.text = "今日も一緒に全力ダッシュ！";
                    anagramText.text = "…今日も一緒に走ったよ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "お父さんは軍人";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 13:
                if (achibmentFlag13)
                {
                    trophyNameText.text = "ただのメガネ";
                    conditionText.text = "羽神和真と結婚した。";
                    detailText.text = "インテリ要素皆無だよー！";
                    anagramText.text = "メガネ似合ってるじゃん…";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "この眼鏡のどこが同じだって言うんですか！";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 14:
                if (achibmentFlag14)
                {
                    trophyNameText.text = "腹筋崩壊！";
                    conditionText.text = "鎌瀬虎次郎と結婚した。";
                    detailText.text = "実はめっちゃいい奴";
                    anagramText.text = "お前といると退屈しないよ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "俺カマセなんだってさ！ひどいよな！";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 15:
                if (achibmentFlag15)
                {
                    trophyNameText.text = "Open your Eyes！";
                    conditionText.text = "檜山善鷹と結婚した。";
                    detailText.text = "目を開けろー！";
                    anagramText.text = "滅多に目を開かないよな…お前";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "僕は糸目じゃないよ？";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 16:
                if (achibmentFlag16)
                {
                    trophyNameText.text = "アマチュアスペシャリスト！";
                    conditionText.text = "専門学校に進学する。";
                    detailText.text = "プロを目指して人生謳歌！";
                    anagramText.text = "暗い部屋で過ごした";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "専門学校に行く";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 17:
                if (achibmentFlag17)
                {
                    trophyNameText.text = "キャンパスライフ！";
                    conditionText.text = "大学に進学する。";
                    detailText.text = "とことん勉学を突き詰めろ！";
                    anagramText.text = "周りは楽しそうだなぁ";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "大学に行く";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 18:
                if (achibmentFlag18)
                {
                    trophyNameText.text = "そう、なぜなら運があるから";
                    conditionText.text = "運で運が上がった。";
                    detailText.text = "本物の運で運を上げろ！";
                    anagramText.text = "神は俺を見捨てた";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "きっと運次第で取れるさ！";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 19:
                if (achibmentFlag19)
                {
                    trophyNameText.text = "あ～あ、やっちゃったね";
                    conditionText.text = "お迎えに上がられる。";
                    detailText.text = "砕かれる思い、途絶える世代";
                    anagramText.text = "どうしてこうなるんだ…";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "一生を終える";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
                }
                break;
            case 20:
                if (achibmentFlag20)
                {
                    trophyNameText.text = "UnHappyRefrain";
                    conditionText.text = "トロフィーをコンプリートした。";
                    detailText.text = "人生なんてそううまくいくもんじゃないんだよ？";
                    anagramText.text = "そして繰り返される";
                }
                else
                {
                    trophyNameText.text = "謎に包まれている";
                    conditionText.text = "全てのトロフィーを獲得する";
                    detailText.text = "謎に包まれている。";
                    anagramText.text = "";
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

    static public void LastTrophyChecker()
    {
        int count = 0;
        for(int i = 0; i > 19; i++)
        {
            if(i < 9)
                count += PlayerPrefs.GetInt("achibmentFlag0" + i.ToString());
            else if(i < 19)
                count += PlayerPrefs.GetInt("achibmentFlag1" + i.ToString());

            if(i == 20)
                PopTrophy.GetTrophy("UnHappyRefrain", "トロフィーをコンプリート", 20);
        }
    }
}
