using UnityEngine;
using System.Collections;

public class HappySystem : MonoBehaviour
{//0.4%
    public GameObject[] leftPos;     //左出現ポジション
    public GameObject[] rightPos;    //右出現ポジション
    private Vector3 spawnPos;     //出現位置
    private Vector3 targetPos;    //目的位置
    private bool touch = false;

    void Start()
    {
        touch = false;
        //spawnPos = rightPos[0].transform.localPosition;
        //targetPos = leftPos[0].transform.localPosition;
        HappyHappy();
        Destroy(this.gameObject, 5f);
    }

    void HappyHappy()
    {
        int rnd = Random.Range(0, 4);
        int id = Random.Range(0, 3);

        /*左右ランダムで出す処理(文字が反転する事から未実装)
        if (rnd % 2 == 0)
        {//左から出現
            iTween.MoveFrom(rightPos[rnd], iTween.Hash("position", leftPos[rnd].gameObject.transform.position, "time", 5f));
        }
        else
        {//右から出現
            iTween.MoveTo(rightPos[rnd], iTween.Hash("position", leftPos[rnd].gameObject.transform.position, "time", 5f));
        }*/

        iTween.PunchScale(rightPos[id], iTween.Hash("x", 1.5, "y", 1.5, "time", 7f));
        iTween.MoveTo(rightPos[id], iTween.Hash("position", leftPos[id].gameObject.transform.position, "time", 15f));
    }

    public void HappyChance()
    {
        if (!touch)
        {
            touch = true;
            Debug.Log("HappyHappy!");
            SoundPlayer.Instance.PlaySE("StatusUp_big");
            Destroy(this.gameObject, 0.5f);
        }
    }
}
