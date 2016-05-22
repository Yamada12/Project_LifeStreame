using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] private Slider _timerSlider;   //棒ゲージ
    [SerializeField] private Text remainingTime;    //残り時間
    private float _time = 180f;    //残り時間最大値(仮)
    string timeText;

    void Start()
    {
        //テスト用にステータスを初期化
        PlayerStatus.initStatus();
        // タイマー用のスライダーを取得する
        _timerSlider = GameObject.Find("Time_Bar").GetComponent<Slider>();
        _timerSlider.maxValue = _time;   //最大値代入
        //残り時間表示用テキスト
        remainingTime.text = "";
    }

    void Update()
    {
        // 時間消費
        PlayerStatus.lifeTime -= Time.deltaTime;

        if (PlayerStatus.lifeTime < 0)
        {// 最大を超えたら0に戻す
            PlayerStatus.lifeTime = 0;
        }
        // HPゲージに値を設定
        _timerSlider.value = PlayerStatus.lifeTime;

        //残り時間テキスト更新
        timeText = string.Format("{0:f4}", PlayerStatus.lifeTime);
        remainingTime.text = "残り時間：" + timeText + " / " + _time;
    }
}
