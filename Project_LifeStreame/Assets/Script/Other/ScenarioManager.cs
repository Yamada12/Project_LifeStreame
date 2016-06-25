using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Novel;

public class ScenarioManager : MonoBehaviour
{
    public GameObject bigEvent_Base;
    public GameObject[] bigEvent;
    public Text titleText;
    public Text explanatoryText;

    public GameObject flyText;

    // Use this for initialization
    void Start()
    {
        bigEvent_Base.SetActive(false);
        flyText.GetComponentInChildren<Text>().text = "ふらーい！";
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStatus.lifeTime <= 1200f && PlayerStatus.lifeTime > 1100f)
        {//4月　花見
            ContentFalser(0);
            titleText.text = "花見";
            explanatoryText.text = "今年も花見のシーズンがやってきた。\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 1100f && PlayerStatus.lifeTime > 1000f)
        {//5月　運動会
            ContentFalser(1);
            titleText.text = "運動会";
            explanatoryText.text = "運動会が開催される。今年は何組だろうか…？\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 1000f && PlayerStatus.lifeTime > 900f)
        {//6月　運動会
            ContentFalser(1);
            titleText.text = "運動会";
            explanatoryText.text = "運動会が開催される。今年は何組だろうか…？\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 900f && PlayerStatus.lifeTime > 800f)
        {//7月　なし
            ContentFalser(10);
            titleText.text = "イベントなし";
            explanatoryText.text = "この時期に大きなイベントは無いようだ。\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 800f && PlayerStatus.lifeTime > 700f)
        {//8月　夏祭り
            ContentFalser(2);
            titleText.text = "夏祭り";
            explanatoryText.text = "近所の神社で夏祭りがあるらしい。誰か誘って行ってみようか…？\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 700f && PlayerStatus.lifeTime > 600f)
        {//9月　文化祭
            ContentFalser(3);
            titleText.text = "文化祭";
            explanatoryText.text = "文化祭の準備が始まった。今年は一体どんな出展があるのだろうか\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 600f && PlayerStatus.lifeTime > 500f)
        {//10月　文化祭
            ContentFalser(3);
            titleText.text = "文化祭";
            explanatoryText.text = "文化祭の準備が始まった。今年は一体どんな出展があるのだろうか\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 500f && PlayerStatus.lifeTime > 400f)
        {//11月　なし
            ContentFalser(10);
            titleText.text = "イベントなし";
            explanatoryText.text = "この時期に大きなイベントは無いようだ。\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 400f && PlayerStatus.lifeTime > 300f)
        {//12月　クリスマス
            ContentFalser(4);
            titleText.text = "クリスマス";
            explanatoryText.text = "今夜はクリスマス。大切な人と一緒に過ごそう。\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 300f && PlayerStatus.lifeTime > 200f)
        {//1月　初詣
            ContentFalser(5);
            titleText.text = "初詣";
            explanatoryText.text = "一年の計は元旦にあり。初詣に出かけよう\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 200f && PlayerStatus.lifeTime > 100f)
        {//2月　バレンタインデー
            ContentFalser(6);
            titleText.text = "バレンタインデー";
            explanatoryText.text = "バレンタインの時期がやってきた。心の準備を整えよう。\n消費時間:70\n";
        }
        else if (PlayerStatus.lifeTime <= 100f && PlayerStatus.lifeTime > 0f)
        {//3月　ホワイトデー
            ContentFalser(7);
            titleText.text = "ホワイトデー";
            explanatoryText.text = "ホワイトデーの時期がやってきた。心の準備を整えよう。\n消費時間:70\n";
        }
        else {
            ContentFalser(10);
        }
    }

    void ContentFalser(int num)
    {//特定のイベント以外falseにする
        if (num >= 10)
            bigEvent_Base.SetActive(false);
        else
            bigEvent_Base.SetActive(true);

        for (int i = 0; i < bigEvent.Length; i++)
        {
            bigEvent[i].SetActive(false);
        }

        bigEvent[num].SetActive(true);
    }

    /// <summary>
    /// 各種ステータス上昇
    /// </summary>
    /// <param name="_?">各種対応したパラメータ</param>
    public void Status_co_Up(float _parameter)
    {//コミュ力の上昇
        PlayerStatus.co += _parameter;
        PlayerPrefs.SetFloat("co", PlayerStatus.co);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
        StartCoroutine(PopText("コミュ力↑", 0f));
    }

    public void Status_ec_Up(float _parameter)
    {//経済力の上昇
        PlayerStatus.ec += _parameter;
        PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
        StartCoroutine(PopText("経済力↑", 0f));
    }

    public void Status_ac_Up(float _parameter)
    {//学力の上昇
        PlayerStatus.ac += _parameter;
        PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
        StartCoroutine(PopText("学力↑", 0f));
    }

    public void Status_hu_Up(float _parameter)
    {//人間力の上昇
        PlayerStatus.hu += _parameter;
        PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
        StartCoroutine(PopText("人間力↑", 0f));
    }

    public void Status_vi_Up(float _parameter)
    {//体力の上昇
        PlayerStatus.vi += _parameter;
        PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
        StartCoroutine(PopText("体力↑", 0f));
    }

    public void Status_lu_Up(float _parameter)
    {//運の上昇
        if (Random.Range(0, 24) == 0)
        {
            PlayerStatus.lu += _parameter;
            PlayerPrefs.SetFloat("lu", PlayerStatus.lu);
            flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperRight;
            StartCoroutine(PopText("運↑", 0f));
        }
        else
        {
            flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerRight;
            StartCoroutine(PopText("運は上がらなかった…", 0f));
        }
    }

    /// <summary>
    /// 各種ステータス減少
    /// </summary>
    /// <param name="_?">各種対応したパラメータ</param>
    public void Status_co_Down(float _parameter)
    {//コミュ力の減少
        PlayerStatus.co -= _parameter;
        if (PlayerStatus.co <= 0)
        {
            PlayerStatus.co = 0;
        }
        PlayerPrefs.SetFloat("co", PlayerStatus.co);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerLeft;
        StartCoroutine(PopText("コミュ力↓", 1f));
    }

    public void Status_ec_Down(float _parameter)
    {//経済力の減少
        PlayerStatus.ec -= _parameter;
        if (PlayerStatus.ec <= 0)
        {
            PlayerStatus.ec = 0;
        }
        PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerLeft;
        StartCoroutine(PopText("経済力↓", 1f));
    }

    public void Status_ac_Down(float _parameter)
    {//学力の減少
        PlayerStatus.ac -= _parameter;
        if (PlayerStatus.ac <= 0)
        {
            PlayerStatus.ac = 0;
        }
        PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerLeft;
        StartCoroutine(PopText("学力↓", 1f));
    }

    public void Status_hu_Down(float _parameter)
    {//人間力の減少
        PlayerStatus.hu -= _parameter;
        if (PlayerStatus.hu <= 0)
        {
            PlayerStatus.hu = 0;
        }
        PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerLeft;
        StartCoroutine(PopText("人間力↓", 1f));
    }

    public void Status_vi_Down(float _parameter)
    {//体力の減少
        PlayerStatus.vi -= _parameter;
        if (PlayerStatus.vi <= 0)
        {
            PlayerStatus.vi = 0;
        }
        PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerLeft;
        StartCoroutine(PopText("体力↓", 1f));
    }

    public void Status_lu_Down(float _parameter)
    {//運の減少
        PlayerStatus.lu -= _parameter;
        if (PlayerStatus.lu <= 0)
        {
            PlayerStatus.lu = 0;
        }
        PlayerPrefs.SetFloat("lu", PlayerStatus.lu);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.LowerLeft;
        StartCoroutine(PopText("運↓", 1f));
    }

    /// <summary>
    /// 外部からコルーチンを呼び出すメソッド
    /// </summary>
    /// <param name="text">ポップさせたい文字列</param>
    /// <param name="time">ディレイの時間</param>
    public void OtherPoper(string text, float time)
    {
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
        StartCoroutine(PopText(text, time));
    }

    /// <summary>
    /// テキストをレーダーの位置に出現させるメソッド
    /// </summary>
    /// <param name="text">表示する内容</param>
    public IEnumerator PopText(string text, float delayTime)
    {
        PlayerStatus.babyCounter();
        flyText.GetComponentInChildren<Text>().text = text;
        if (delayTime <= 0)
        {
            flyText.GetComponentInChildren<Text>().color = new Color(36f / 255f, 253f / 255f, 42f / 255f);
            GameObject obj = Instantiate(flyText) as GameObject;
            SoundPlayer.Instance.PlaySE("StatusUp");
            StopAllCoroutines();
        }
        yield return new WaitForSeconds(delayTime);
        if (delayTime <= 0.5 && delayTime > 0)
        {
            flyText.GetComponentInChildren<Text>().color = new Color(36f / 255f, 253f / 255f, 42f / 255f);
            GameObject obj = Instantiate(flyText) as GameObject;
            SoundPlayer.Instance.PlaySE("StatusUp");
            StopAllCoroutines();
        }
        else if (delayTime >= 1)
        {
            flyText.GetComponentInChildren<Text>().color = new Color(34f / 255f, 151f / 255f, 244f / 255f);
            GameObject obj02 = Instantiate(flyText) as GameObject;
            SoundPlayer.Instance.PlaySE("StatusUp");
            StopAllCoroutines();
        }
    }

    /// <summary>
    /// 時間消費（イベントのボタンに必ずいれる）
    /// </summary>
    /// <param name="lostTime">消費する時間</param>
    public void Status_LostTime(float lostTime)
    {//時間消費
        PlayerStatus.lifeTime -= lostTime;
        if (PlayerStatus.lifeTime <= 0)
        {
            PlayerStatus.lifeTime = 0;
        }
        PlayerPrefs.SetFloat("lifeTime", PlayerStatus.lifeTime);
    }

    public void Working()
    {
        switch (PlayerStatus.job)
        {
            case "フリーター"://フリーター
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "フリーター";
                break;
            case "サラリーマン"://サラリーマン
                PlayerStatus.ec += 12;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "サラリーマン";
                break;
            case "料理人"://料理人
                PlayerStatus.ec += 15;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "料理人";
                break;
            case "医者"://医者
                PlayerStatus.ec += 30;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "医者";
                break;
            case "芸能人"://芸能人
                PlayerStatus.ec += 15;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "芸能人";
                break;
            case "警察"://警察
                PlayerStatus.ec += 24;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "警察";
                break;
            case "教師"://教師
                PlayerStatus.ec += 23;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "教師";
                break;
            case "消防士"://消防士
                PlayerStatus.ec += 25;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "消防士";
                break;
            case "自衛隊"://自衛隊
                PlayerStatus.ec += 18;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "自衛隊";
                break;
            case "スポーツ選手"://スポーツ選手
                PlayerStatus.ec += 100;
                PlayerStatus.lifeTime -= 150;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "スポーツ選手";
                break;
            case "美容師"://美容師
                PlayerStatus.ec += 18;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "美容師";
                break;
            case "システムエンジニア"://システムエンジニア
                PlayerStatus.ec += 21;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "システムエンジニア";
                break;
            case "音楽家"://音楽家
                PlayerStatus.ec += 17;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "音楽家";
                break;
            case "農家"://農家
                PlayerStatus.ec += 16;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "農家";
                break;
            case "小説家"://小説家
                PlayerStatus.ec += 15;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "小説家";
                break;
            case "科学者"://科学者
                PlayerStatus.ec += 32;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "科学者";
                break;
            case "運送業"://運送業
                PlayerStatus.ec += 22;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "運送業";
                break;
            case "土木業"://土木業
                PlayerStatus.ec += 16;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "土木業";
                break;
            case "デザイナー"://デザイナー
                PlayerStatus.ec += 19;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "デザイナー";
                break;
            case "歌手"://歌手
                PlayerStatus.ec += 20;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "歌手";
                break;
            case "カメラマン"://カメラマン
                PlayerStatus.ec += 15;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "カメラマン";
                break;
            case "宇宙飛行士"://宇宙飛行士
                PlayerStatus.ec += 42;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "宇宙飛行士";
                break;
            case "漁師"://漁師
                PlayerStatus.ec += 20;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "漁師";
                break;
            case "ダンサー"://ダンサー
                PlayerStatus.ec += 17;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "ダンサー";
                break;
            case "弁護士"://弁護士
                PlayerStatus.ec += 30;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "弁護士";
                break;
            case "占い師"://†占い師†
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "占い師";
                break;
            case "執事・メイド"://†執事・メイド†
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "執事・メイド";
                break;
            case "正義の味方"://†正義の味方†
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "正義の味方";
                break;
            case "スタントマン"://†スタントマン†
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "スタントマン";
                break;
            case "配管工"://†配管工†
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "配管工";
                break;
            case "ギャンブラー"://†ギャンブラー†
                float rnd = Random.Range(0, 1000);
                if (rnd <= PlayerStatus.lu)
                {
                    PlayerStatus.ec += 60;
                    flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                    StartCoroutine(PopText("運がいいね！", 0f));
                }
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("何も起こらなかった", 0f));
                PlayerStatus.job = "ギャンブラー";
                break;
            case "王子・王女"://‡王子・王女‡
                PlayerStatus.ec += 50;
                PlayerStatus.ac += 50;
                PlayerStatus.lu += 50;
                PlayerStatus.vi += 50;
                PlayerStatus.hu += 50;
                PlayerStatus.co += 50;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("無双", 0f));
                PlayerStatus.job = "王子・王女";
                break;
            default:
                PlayerStatus.ec += 10;
                PlayerStatus.lifeTime -= 50;
                flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperCenter;
                StartCoroutine(PopText("経済力↑", 0f));
                PlayerStatus.job = "フリーター";
                break;
        }
    }

    /// <summary>
    /// 出会いイベント（特定イベントのボタンに必ずいれる）
    /// </summary>
    /// <param name="lostTime">消費する時間</param>
    public void EncountCharacter(string charaName)
    {//キャラ毎の出会いシーンに遷移
        int rnd = Random.Range(0, 3);
        Debug.Log("今回の値：" + rnd);
        if (rnd == 0)
        {
            switch (charaName)
            {
                case "tundere":
                    if (PlayerStatus.mf == 1)
                        break;
                    if (PlayerStatus.lp_tun <= 0)
                    {//ツンデレと出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/K_tun", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/D_tun", "");
                        }
                    }
                    break;
                case "majime":
                    if (PlayerStatus.mf == 1)
                        break;
                    if (PlayerStatus.lp_maji <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/K_majime", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/D_majime", "");
                        }
                    }
                    break;
                case "supokon":
                    if (PlayerStatus.mf == 1)
                        break;
                    if (PlayerStatus.lp_supo <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/K_supo", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/D_supo", "");
                        }
                    }
                    break;
                case "interi":
                    if (PlayerStatus.mf == 0)
                        break;
                    if (PlayerStatus.lp_mega <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/K_interi", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/D_interi", "");
                        }
                    }
                    break;
                case "kamase":
                    if (PlayerStatus.mf == 0)
                        break;
                    if (PlayerStatus.lp_kama <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/K_kamase", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/D_kamase", "");
                        }
                    }
                    break;
                case "nagoyaka":
                    if (PlayerStatus.mf == 0)
                        break;
                    if (PlayerStatus.lp_nago <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/K_nagoyaka", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/D_nagoyaka", "");
                        }
                    }
                    break;
            }
        }
    }
}
