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
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperLeft;
        StartCoroutine(PopText("コミュ力↑", 0f));
    }

    public void Status_ec_Up(float _parameter)
    {//経済力の上昇
        PlayerStatus.ec += _parameter;
        PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperLeft;
        StartCoroutine(PopText("経済力↑", 0f));
    }

    public void Status_ac_Up(float _parameter)
    {//学力の上昇
        PlayerStatus.ac += _parameter;
        PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperLeft;
        StartCoroutine(PopText("学力↑", 0f));
    }

    public void Status_hu_Up(float _parameter)
    {//人間力の上昇
        PlayerStatus.hu += _parameter;
        PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperLeft;
        StartCoroutine(PopText("人間力↑", 0f));
    }

    public void Status_vi_Up(float _parameter)
    {//体力の上昇
        PlayerStatus.vi += _parameter;
        PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
        flyText.GetComponentInChildren<Text>().alignment = TextAnchor.UpperLeft;
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
    /// テキストをレーダーの位置に出現させるメソッド
    /// </summary>
    /// <param name="text">表示する内容</param>
    private IEnumerator PopText(string text, float delayTime)
    {
        flyText.GetComponentInChildren<Text>().text = text;
        if (delayTime <= 0)
        {
            flyText.GetComponentInChildren<Text>().color = new Color(36f / 255f, 253f / 255f, 42f / 255f);
            GameObject obj = Instantiate(flyText) as GameObject;
            SoundPlayer.Instance.PlaySE("StatusUp");
            StopAllCoroutines();
        }
        yield return new WaitForSeconds(delayTime);
        if (delayTime >= 0.5)
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

    /// <summary>
    /// 出会いイベント（特定イベントのボタンに必ずいれる）
    /// </summary>
    /// <param name="lostTime">消費する時間</param>
    public void EncountCharacter(string charaName)
    {//キャラ毎の出会いシーンに遷移
        int rnd = Random.Range(0, 3);
        Debug.Log("今回の値：" + rnd);
        PlayerStatus.initStatus();//デバッグ用
        if (rnd == 0)
        {
            switch (charaName)
            {
                case "tundere":
                    if (PlayerStatus.lp_tun <= 0)
                    {//ツンデレと出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.lp_tun += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/K_tun", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.lp_tun += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/D_tun", "");
                        }
                    }
                    break;
                case "majime":
                    if (PlayerStatus.lp_maji <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.lp_maji += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/K_majime", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.lp_maji += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/D_majime", "");
                        }
                    }
                    break;
                case "supokon":
                    if (PlayerStatus.lp_supo <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.lp_supo += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/K_supo", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.lp_supo += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/D_supo", "");
                        }
                    }
                    break;
                case "interi":
                    if (PlayerStatus.lp_mega <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.lp_mega += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/K_interi", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.lp_mega += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/D_interi", "");
                        }
                    }
                    break;
                case "kamase":
                    if (PlayerStatus.lp_kama <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.lp_kama += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/K_kamase", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.lp_kama += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/D_kamase", "");
                        }
                    }
                    break;
                case "nagoyaka":
                    if (PlayerStatus.lp_nago <= 0)
                    {//出会ったことが無ければ
                        if (PlayerStatus.progress == 3)
                        {//高校以下なら高校の出会いシーン
                            PlayerStatus.lp_nago += 1;
                            PlayerStatus.InitConverter();
                            PlayerStatus.static_Save();
                            NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/K_nagoyaka", "");
                        }
                        else if (PlayerStatus.progress >= 4)
                        {//専門学校以上なら社会の出会いシーン
                            PlayerStatus.lp_nago += 1;
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
