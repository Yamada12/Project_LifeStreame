using UnityEngine;
using System.Collections;

public class TestAnim : MonoBehaviour
{
    public GameObject basePoint;   //左から来るボタンのアニメーション開始前の座標地点


    void Start()
    {
        //this.gameObject.transform.parent.gameObject.GetComponent<Canvas>().renderer
        iTween.MoveFrom(this.gameObject, iTween.Hash("position", basePoint.gameObject.transform.position, "time", 1f));
        Invoke("DestroySelf", 1f);
    }

    /// <summary>
    /// 自身を消去する
    /// </summary>
    void DestroySelf()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
}
