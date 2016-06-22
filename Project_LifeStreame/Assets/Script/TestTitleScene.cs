using UnityEngine;
using System.Collections;

public class TestTitleScene : MonoBehaviour
{
    public GameObject[] titleObject;
    public GameObject diary = null;
    public GameObject page = null;
    public GameObject cameraObject;
    public GameObject[] movePoint;  //移動位置のカメラ

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// <summary>
    /// タイトルオブジェクトを消去する
    /// </summary>
    public void EraseTitleObject()
    {
        for (int i = 0; i < titleObject.Length; i++)
        {
            titleObject[i].SetActive(false);
        }
    }

    /// <summary>
    /// タイトル演出アニメーション
    /// </summary>
    public void TitleMoveAnimation()
    {
        //iTween.MoveTo(cameraObject, iTween.Hash("position", movePoint[0].transform.position, "time", 1f));
        //iTween.RotateTo(cameraObject, iTween.Hash("z", 341.1095, "time", 1f));
        Invoke("TitleMoveAnimation02", 1f);
        //iTween.ScaleTo(basePoint, iTween.Hash("x", 1.25f, "y", 1.25f, "time", 1f));
        //iTween.RotateTo(basePoint, iTween.Hash("y", 360, "time", 1f));
    }

    public void TitleMoveAnimation02()
    {
        EraseTitleObject();
        iTween.RotateTo(page, iTween.Hash("y", 180, "z", 33, "time", 5f));
        iTween.ScaleTo(page, iTween.Hash("x", 0.25f, "time", 1f));
        //iTween.RotateTo(cameraObject, iTween.Hash("z", 360, "time", 0.5f));
        iTween.MoveTo(cameraObject, iTween.Hash("position", movePoint[1].transform.position, "time", 1f));
    }
}
