using UnityEngine;
using System.Collections;

public class ScenarioManager : MonoBehaviour
{
    public string sceneName;
    public GameObject bigEvent;

    // Use this for initialization
    void Start()
    {
        bigEvent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStatus.lifeTime <= 1780f && PlayerStatus.lifeTime >= 1000f)
        {
            bigEvent.SetActive(true);
        } else {
            bigEvent.SetActive(false);
        }
    }

    /// <summary>
    /// 各種ステータス上昇
    /// </summary>
    /// <param name="_?">各種対応したパラメータ</param>
    public void Status_co_Up(float _parameter)
    {//コミュ力の上昇
        PlayerStatus.co += _parameter;
    }

    public void Status_ec_Up(float _parameter)
    {//経済力の上昇
        PlayerStatus.ec += _parameter;
    }

    public void Status_ac_Up(float _parameter)
    {//学力の上昇
        PlayerStatus.ac += _parameter;
    }

    public void Status_hu_Up(float _parameter)
    {//人間力の上昇
        PlayerStatus.hu += _parameter;
    }

    public void Status_vi_Up(float _parameter)
    {//人間力の上昇
        PlayerStatus.vi += _parameter;
    }

    public void Status_lu_Up(float _parameter)
    {//運の上昇
        if (Random.Range(0, 24) == 0)
        {
            PlayerStatus.lu += _parameter;
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
    }

    public void Status_ec_Down(float _parameter)
    {//経済力の減少
        PlayerStatus.ec -= _parameter;
        if (PlayerStatus.ec <= 0)
        {
            PlayerStatus.ec = 0;
        }
    }

    public void Status_ac_Down(float _parameter)
    {//学力の減少
        PlayerStatus.ac -= _parameter;
        if (PlayerStatus.ac <= 0)
        {
            PlayerStatus.ac = 0;
        }
    }

    public void Status_hu_Down(float _parameter)
    {//人間力の減少
        PlayerStatus.hu -= _parameter;
        if (PlayerStatus.hu <= 0)
        {
            PlayerStatus.hu = 0;
        }
    }

    public void Status_vi_Down(float _parameter)
    {//体力の減少
        PlayerStatus.vi -= _parameter;
        if (PlayerStatus.vi <= 0)
        {
            PlayerStatus.vi = 0;
        }
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
    }
}
