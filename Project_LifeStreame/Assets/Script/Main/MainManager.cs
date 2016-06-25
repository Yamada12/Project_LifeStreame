using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Novel;

/// <summary>
/// メインシーンを管理するスクリプト
/// シーン上の空のオブジェクトにアタッチする
/// </summary>
public class MainManager : MonoBehaviour
{
    [SerializeField] private Slider _timerSlider;   //棒ゲージ
    [SerializeField] private Text remainingTime;    //残り時間
    private float _time = 1200f;    //残り時間最大値(仮)
    private float _MethodTime;
    static public bool pauseFlag = true;   //trueならポーズ
    public GameObject endPanel = null;
    public EventButton_Manager ev = null;
    public GameObject happyObj = null;      //ハッピーシステムのオブジェクト
    public GameObject menuButton = null;    //メニューボタン
    public GameObject love_Button = null;   //連絡ボタン
    public GameObject storkObj = null;      //コウノトリシステムのオブジェクト
    string timeText;

    void Start()
    {
        if (PlayerPrefs.HasKey("0"))
        {//初回起動ではない場合
            pauseFlag = false;
            PlayerStatus.lifeTime = PlayerPrefs.GetFloat("lifeTime");
            ev.Load_UseCount();
            ev.Save_UseCount();
            PlayerStatus.static_Load();
            ev.InteractiveCheck();
            Debug.Log("初回起動じゃないよ！");
        }
        else {
            Debug.Log("初回起動だよ！");
            pauseFlag = true;
            ev.InitDelete();
            ev.Save_UseCount();
            PlayerStatus.lifeTime = 1200;
            PlayerStatus.static_Save();
        }
        StartBGM();
        // タイマー用のスライダーを取得する
        _timerSlider = GameObject.Find("Time_Bar").GetComponent<Slider>();
        _timerSlider.maxValue = _time;   //最大値代入
        endPanel.SetActive(false);
        //残り時間表示用テキスト
        remainingTime.text = "";
        StartCoroutine(HappySpawn());
        if (PlayerStatus.progress < 2)
        {
            menuButton.GetComponent<Button>().interactable = false;
            love_Button.GetComponent<Button>().interactable = false;
        }
        else if (PlayerStatus.progress < 3)
        {
            menuButton.GetComponent<Button>().interactable = true;
            love_Button.GetComponent<Button>().interactable = false;
        }
        else
        {
            menuButton.GetComponent<Button>().interactable = true;
            love_Button.GetComponent<Button>().interactable = true;
        }
    }

    void Update()
    {
        if (PlayerStatus.babyCount <= 0 && PlayerStatus.children <= 0)
        {
            GameObject obj = Instantiate(storkObj) as GameObject;
        }
        if (!pauseFlag)
        {
            // 時間消費
            PlayerStatus.lifeTime -= Time.deltaTime;
        }

        if (PlayerStatus.lifeTime < 0)
        {// 0を超えたら0に戻す
            SoundPlayer.Instance.PlayBGM("TimeUp");
            PlayerStatus.lifeTime = 0;
            endPanel.SetActive(true);
            pauseFlag = true;
            if(PlayerStatus.progress == 5)  //専門学校パートなら2を代入して強制的に社会人パートへ
                PlayerStatus.progress += 2;
            else
                PlayerStatus.progress += 1;

            StartCoroutine(ReturnWorld());
        }
        // HPゲージに値を設定
        _timerSlider.value = PlayerStatus.lifeTime;

        //残り時間テキスト更新
        timeText = string.Format("{0:f4}", PlayerStatus.lifeTime);
        remainingTime.text = "残り時間：" + timeText + " / " + _time;
    }

    IEnumerator HappySpawn()
    {
        yield return new WaitForSeconds(1f);
        float rnd = Random.Range(0, 200);
        if (rnd == 1)
        {//0.5%でハッピーになれます
            GameObject obj = Instantiate(happyObj) as GameObject;
        }
        StartCoroutine(HappySpawn());
    }

    void StartBGM()
    {
        switch (PlayerStatus.progress)
        {
            case 1://小学校パート
                SoundPlayer.Instance.PlayBGM("ES01");
                Debug.Log(PlayerStatus.progress + "小学校のBGMが鳴っています。");
                break;
            case 2://中学校パート
                SoundPlayer.Instance.PlayBGM("JHS01");
                Debug.Log(PlayerStatus.progress + "中学校のBGMが鳴っています。");
                break;
            case 3://高校パート
                SoundPlayer.Instance.PlayBGM("HS");
                Debug.Log(PlayerStatus.progress + "高校のBGMが鳴っています。");
                break;
            case 5://専門学校パート
                SoundPlayer.Instance.PlayBGM("Pro01");
                Debug.Log(PlayerStatus.progress + "専門学校のBGMが鳴っています。");
                break;
            case 6://大学パート
                SoundPlayer.Instance.PlayBGM("College01");
                Debug.Log(PlayerStatus.progress + "大学のBGMが鳴っています。");
                break;
            case 7://社会人パート
                SoundPlayer.Instance.PlayBGM("Society01");
                Debug.Log(PlayerStatus.progress + "社会人のBGMが鳴っています。");
                break;
            default:
                SoundPlayer.Instance.PlayBGM("reco_march120");
                Debug.Log("Progressの値はおかしいです！");
                break;
        }
    }
    /// <summary>
    /// 時間のカウントを開始する
    /// </summary>
    public void StartCount()
    {
        pauseFlag = false;
    }

    /// <summary>
    /// 終了処理をしてWorldシーンに戻る
    /// </summary>
    IEnumerator  ReturnWorld()
    {
        Destroy(GameObject.Find("Licence_Canvas(Clone)"));
        Destroy(GameObject.Find("Love_Canvas(Clone)"));
        Destroy(GameObject.Find("Happy!(Clone)"));
        yield return new WaitForSeconds(4f);
        ev.InitDelete();
        //World_Player.result = 0;
        World_Player.shiken = 0;
        PlayerStatus.lifeTime = 1200;
        PlayerStatus.static_Save();
        SceneManager.LoadScene("World", LoadSceneMode.Single);
    }
}