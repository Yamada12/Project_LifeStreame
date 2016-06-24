using UnityEngine;
using System.Collections;

public class StrokSystem : MonoBehaviour
{
    public GameObject spawnPos = null;    //出現ポジション
    public GameObject centerPos = null;     //中央位置
    public GameObject targetPos = null;    //目的位置

    public GameObject babyObject = null;    //かご
    public GameObject fallPoint = null;     //落ちてくる位置

    void Start()
    {
        SummonBird();
        PlayerStatus.children += 1;
        PlayerStatus.static_Save();
    }

    void SummonBird()
    {
        iTween.MoveTo(spawnPos, iTween.Hash("position", centerPos.transform.position, "time", 3f, "oncomplete", "Baby", "oncompletetarget", this.gameObject));
    }

    void SummonBird02()
    {
        iTween.MoveTo(spawnPos, iTween.Hash("position", targetPos.transform.position, "time", 3f));
        Destroy(this.gameObject, 2f);
    }

    void Baby()
    {
        iTween.MoveTo(babyObject, iTween.Hash("position", fallPoint.transform.position, "time", 1f, "oncomplete", "SummonBird02", "oncompletetarget", this.gameObject));
        babyObject.transform.parent = spawnPos.transform.parent;
        Debug.Log("SummonBird!");
        SoundPlayer.Instance.PlaySE("StatusUp_big");
    }
}
