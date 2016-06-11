using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// メインシーンを管理するスクリプト
/// シーン上の空のオブジェクトにアタッチする
/// </summary>
public class MainManager : MonoBehaviour
{
    [SerializeField] private Slider _timerSlider;   //棒ゲージ
    [SerializeField] private Text remainingTime;    //残り時間
    private float _time = 1200f;    //残り時間最大値(仮)
    static public bool pauseFlag = true;   //trueならポーズ
    public GameObject endPanel = null;
    string timeText;

    void Start()
    {
        if (PlayerPrefs.HasKey("0"))
        {
            pauseFlag = false;
            PlayerStatus.lifeTime = PlayerPrefs.GetFloat("lifeTime");
        }
        // タイマー用のスライダーを取得する
        _timerSlider = GameObject.Find("Time_Bar").GetComponent<Slider>();
        _timerSlider.maxValue = _time;   //最大値代入
        endPanel.SetActive(false);
        //残り時間表示用テキスト
        remainingTime.text = "";
    }

    void Update()
    {
        if (!pauseFlag)
        {
            // 時間消費
            PlayerStatus.lifeTime -= Time.deltaTime;
        }

        if (PlayerStatus.lifeTime < 0)
        {// 0を超えたら0に戻す
            PlayerStatus.lifeTime = 0;
            endPanel.SetActive(true);
            pauseFlag = true;
            PlayerStatus.progress += 1;
            Invoke("ReturnWorld", 3.0f);
        }
        // HPゲージに値を設定
        _timerSlider.value = PlayerStatus.lifeTime;

        //残り時間テキスト更新
        timeText = string.Format("{0:f4}", PlayerStatus.lifeTime);
        remainingTime.text = "残り時間：" + timeText + " / " + _time;
    }

    void ReturnWorld()
    {
        SceneManager.LoadScene("World", LoadSceneMode.Single);
    }
}