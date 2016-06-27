using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

public class StrokSystem : MonoBehaviour
{
    public GameObject spawnPos = null;    //出現ポジション
    public GameObject centerPos = null;     //中央位置
    public GameObject targetPos = null;    //目的位置

    public GameObject babyObject = null;    //かご
    public GameObject fallPoint = null;     //落ちてくる位置
    public Text babyText = null;            //テキスト格納

    void Start()
    {
        babyText.text = "";
        babyText.resizeTextForBestFit = false;
        SummonBird();
        PlayerStatus.children += 1;
        PlayerStatus.static_Save();
    }

    void SummonBird()
    {
        iTween.MoveTo(babyObject, iTween.Hash("position", centerPos.transform.position, "time", 3f, "oncomplete", "Baby", "oncompletetarget", this.gameObject));
    }

    void SummonBird02()
    {
        iTween.MoveTo(spawnPos, iTween.Hash("position", targetPos.transform.position, "time", 3f));
        iTween.ScaleTo(babyObject, iTween.Hash("x", 3f, "y", 3f, "time", 1f, "oncomplete", "TextFit", "oncompletetarget", this.gameObject));
    }

    void Baby()
    {
        spawnPos.transform.parent = babyObject.transform.parent;
        iTween.MoveTo(babyObject, iTween.Hash("position", fallPoint.transform.position, "time", 1f, "oncomplete", "SummonBird02", "oncompletetarget", this.gameObject));
        SoundPlayer.Instance.PlaySE("StatusUp_big");
    }

    void TextFit()
    {
        babyText.text = "クリックしてね！";
        babyText.resizeTextForBestFit = true;
    }

    public void HappyBaby()
    {
        PlayerStatus.InitConverter();
        NovelSingleton.StatusManager.callJoker("wide/Happy/H_baby", "");
    }
}
