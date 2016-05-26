using UnityEngine;
using System.Collections;

/// <summary>
/// メインシーンのカメラの動きを管理するスクリプト
/// メインカメラにアタッチする
/// </summary>
public class Main_Camera_Manager : MonoBehaviour
{
    public GameObject originalObject;   //初期位置（原点）
    public GameObject[] targetObject;   //移動位置の座標オブジェクト

    /// <summary>
    /// カメラを各ポイントにアニメーションさせるメソッド
    /// </summary>
    /// <param name="point">ポイント座標</param>
    public void CameraMove(int point)
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 10f, "y", 10f, "z", 1f, "time", 0.5f));
        iTween.MoveTo(this.gameObject, iTween.Hash("x", targetObject[point - 1].transform.position.x, "y", targetObject[point - 1].transform.position.y, "z", targetObject[point - 1].transform.position.z, "time", 0.5f));
    }

    /// <summary>
    /// カメラを初期位置に戻すメソッド
    /// </summary>
    public void OriginalMove()
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 1f, "y", 1f, "z", 1f, "time", 0.5f));
        iTween.MoveTo(this.gameObject, iTween.Hash("position", originalObject.transform.position, "time", 0.5f));
    }
}
