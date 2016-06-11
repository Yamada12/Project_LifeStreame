using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScenarioManager : MonoBehaviour
{
    public GameObject bigEvent_Base;
    public GameObject[] bigEvent;
    public Text titleText;
    public Text explanatoryText;

    // Use this for initialization
    void Start()
    {
        bigEvent_Base.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStatus.lifeTime <= 1200f && PlayerStatus.lifeTime > 1100f)
        {//4月　花見
            ContentFalser(0);
            titleText.text = "花見";
            explanatoryText.text = "今年も花見のシーズンがやってきた。";
        }
        else if (PlayerStatus.lifeTime <= 1100f && PlayerStatus.lifeTime > 1000f)
        {//5月　運動会
            ContentFalser(1);
            titleText.text = "運動会";
            explanatoryText.text = "運動会が開催される。今年は何組だろうか…？";
        }
        else if (PlayerStatus.lifeTime <= 1000f && PlayerStatus.lifeTime > 900f)
        {//6月　運動会
            ContentFalser(1);
            titleText.text = "運動会";
            explanatoryText.text = "運動会が開催される。今年は何組だろうか…？";
        }
        else if (PlayerStatus.lifeTime <= 900f && PlayerStatus.lifeTime > 800f)
        {//7月　なし
            ContentFalser(10);
            titleText.text = "イベントなし";
            explanatoryText.text = "この時期に大きなイベントは無いようだ。";
        }
        else if (PlayerStatus.lifeTime <= 800f && PlayerStatus.lifeTime > 700f)
        {//8月　夏祭り
            ContentFalser(2);
            titleText.text = "夏祭り";
            explanatoryText.text = "近所の神社で夏祭りがあるらしい。誰か誘って行ってみようか…？";
        }
        else if (PlayerStatus.lifeTime <= 700f && PlayerStatus.lifeTime > 600f)
        {//9月　文化祭
            ContentFalser(3);
            titleText.text = "文化祭";
            explanatoryText.text = "文化祭の準備が始まった。今年は一体どんな出展があるのだろうか";
        }
        else if (PlayerStatus.lifeTime <= 600f && PlayerStatus.lifeTime > 500f)
        {//10月　文化祭
            ContentFalser(3);
            titleText.text = "文化祭";
            explanatoryText.text = "文化祭の準備が始まった。今年は一体どんな出展があるのだろうか";
        }
        else if (PlayerStatus.lifeTime <= 500f && PlayerStatus.lifeTime > 400f)
        {//11月　なし
            ContentFalser(10);
            titleText.text = "イベントなし";
            explanatoryText.text = "この時期に大きなイベントは無いようだ。";
        }
        else if (PlayerStatus.lifeTime <= 400f && PlayerStatus.lifeTime > 300f)
        {//12月　クリスマス
            ContentFalser(4);
            titleText.text = "クリスマス";
            explanatoryText.text = "今夜はクリスマス。大切な人と一緒に過ごそう。";
        }
        else if (PlayerStatus.lifeTime <= 300f && PlayerStatus.lifeTime > 200f)
        {//1月　初詣
            ContentFalser(5);
            titleText.text = "初詣";
            explanatoryText.text = "一年の計は元旦にあり。初詣に出かけよう";
        }
        else if (PlayerStatus.lifeTime <= 200f && PlayerStatus.lifeTime > 100f)
        {//2月　バレンタインデー
            ContentFalser(6);
            titleText.text = "バレンタインデー";
            explanatoryText.text = "バレンタインの時期がやってきた。心の準備を整えよう。";
        }
        else if (PlayerStatus.lifeTime <= 100f && PlayerStatus.lifeTime > 0f)
        {//3月　ホワイトデー
            ContentFalser(7);
            titleText.text = "ホワイトデー";
            explanatoryText.text = "ホワイトデーの時期がやってきた。心の準備を整えよう。";
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
    }

    public void Status_ec_Up(float _parameter)
    {//経済力の上昇
        PlayerStatus.ec += _parameter;
        PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
    }

    public void Status_ac_Up(float _parameter)
    {//学力の上昇
        PlayerStatus.ac += _parameter;
        PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
    }

    public void Status_hu_Up(float _parameter)
    {//人間力の上昇
        PlayerStatus.hu += _parameter;
        PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
    }

    public void Status_vi_Up(float _parameter)
    {//人間力の上昇
        PlayerStatus.vi += _parameter;
        PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
    }

    public void Status_lu_Up(float _parameter)
    {//運の上昇
        if (Random.Range(0, 24) == 0)
        {
            PlayerStatus.lu += _parameter;
            PlayerPrefs.SetFloat("lu", PlayerStatus.lu);
            Debug.Log("上がった！");
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
    }

    public void Status_ec_Down(float _parameter)
    {//経済力の減少
        PlayerStatus.ec -= _parameter;
        if (PlayerStatus.ec <= 0)
        {
            PlayerStatus.ec = 0;
        }
        PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
    }

    public void Status_ac_Down(float _parameter)
    {//学力の減少
        PlayerStatus.ac -= _parameter;
        if (PlayerStatus.ac <= 0)
        {
            PlayerStatus.ac = 0;
        }
        PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
    }

    public void Status_hu_Down(float _parameter)
    {//人間力の減少
        PlayerStatus.hu -= _parameter;
        if (PlayerStatus.hu <= 0)
        {
            PlayerStatus.hu = 0;
        }
        PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
    }

    public void Status_vi_Down(float _parameter)
    {//体力の減少
        PlayerStatus.vi -= _parameter;
        if (PlayerStatus.vi <= 0)
        {
            PlayerStatus.vi = 0;
        }
        PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
    }

    public void Status_lu_Down(float _parameter)
    {//運の減少
        if (Random.Range(0, 24) == 0)
        {
            PlayerStatus.lu -= _parameter;
            if (PlayerStatus.lu <= 0)
            {
                PlayerStatus.lu = 0;
            }
            PlayerPrefs.SetFloat("lu", PlayerStatus.lu);
            Debug.Log("下がった！");
        }
    }

    /// <summary>
    /// 時間消費（イベントのボタンに必ずいれる）
    /// </summary>
    /// <param name="lostTime">消費する時間</param>
    public void Status_LostTime(float lostTime)
    {//時間消費
        PlayerStatus.lifeTime -= lostTime;
        if(PlayerStatus.lifeTime <= 0)
        {
            PlayerStatus.lifeTime = 0;
        }
        PlayerPrefs.SetFloat("lifeTime", PlayerStatus.lifeTime);
    }
}
