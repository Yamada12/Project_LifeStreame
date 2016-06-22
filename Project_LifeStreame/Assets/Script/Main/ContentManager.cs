using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// メインシーンのイベントボタンを管理するスクリプト
/// </summary>
public class ContentManager : MonoBehaviour
{
    public GameObject[] targetContent;  //アニメーションさせたいボタン
    public GameObject basePoint;        //初期位置(Closedボタン)

    /// <summary>
    /// イベントボタンを展開する
    /// </summary>
    public void OpenContent()
    {
        this.gameObject.SetActive(false);
        SoundPlayer.Instance.PlaySE("Content_Enter");

        for (int i = 0; i < targetContent.Length; i++)
        {
            targetContent[i].SetActive(true);

            iTween.ScaleFrom(targetContent[i], iTween.Hash("x", 0.1f, "y", 0.1f, "z", 0.1f, "time", 0.5f));
            iTween.MoveFrom(targetContent[i], iTween.Hash("position", basePoint.gameObject.transform.position, "time", 0.5f));
        }
    }
}
