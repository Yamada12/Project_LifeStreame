using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject[] titleObject;
    public GameObject diary = null;
    public GameObject page = null;
    public GameObject cameraObject;
    public GameObject[] movePoint;  //移動位置のカメラ
    public GameObject settingCanvas = null;
    public GameObject warningPanel = null;

    // Use this for initialization
    void Start()
    {
        PlayerStatus.static_Load();
        settingCanvas.SetActive(false);
        close();
    }

    /// <summary>
    /// タイトルオブジェクトを消去する
    /// </summary>
    public void EraseTitleObject(bool Erase = false)
    {
        if (Erase)
        {
            for (int i = 0; i < titleObject.Length; i++)
            {
                titleObject[i].SetActive(false);
            }
            settingCanvas.SetActive(true);
        }
        else
        {
            for (int i = 0; i < titleObject.Length; i++)
            {
                titleObject[i].SetActive(true);
            }
            settingCanvas.SetActive(false);
        }
    }

    /// <summary>
    /// タイトル演出アニメーション
    /// </summary>
    public void TitleMoveAnimation(bool open)
    {
        if (open)
        {
            SoundPlayer.Instance.PlaySE("Maru");
            EraseTitleObject(true);
            iTween.RotateTo(page, iTween.Hash("y", 180, "z", 33, "time", 5f));
            iTween.ScaleTo(page, iTween.Hash("x", 0.25f, "time", 1f));
            iTween.MoveTo(cameraObject, iTween.Hash("position", movePoint[0].transform.position, "time", 1f));
            iTween.MoveFrom(settingCanvas, iTween.Hash("x", -100, "time", 1f));
            SoundPlayer.Instance.PlaySE("Page");
        }
        else
        {
            EraseTitleObject(false);
            iTween.RotateTo(page, iTween.Hash("y", 360, "z", 343.359, "time", 1.7f));
            iTween.ScaleTo(page, iTween.Hash("x", 0.75f, "time", 2f));
            iTween.MoveTo(cameraObject, iTween.Hash("position", movePoint[1].transform.position, "time", 6f));
            iTween.MoveTo(settingCanvas, iTween.Hash("x", -100, "time", 1f));
            SoundPlayer.Instance.PlaySE("book");
        }
    }


    public void StartGame()
    {
        Debug.Log("進行度:" + PlayerStatus.progress);
        if (PlayerStatus.progress != 0)//進行度が0じゃなかったら
        {
            warningPanel.SetActive(true);
            warningPanel.GetComponentInChildren<Text>().text = "前回のプレイデータが残っています！\n初めから開始してもよろしいですか？";
        }
        else
            TitleMoveAnimation(true);
    }

    public void Continue()
    {
        if (PlayerStatus.progress == 0)//進行度が0だったら
            TitleMoveAnimation(true);
        else if(PlayerStatus.progress == 7)
            SceneManager.LoadScene("Main");
        else
            SceneManager.LoadScene("World");
    }

    public void close()
    {//Warningのパネル
        warningPanel.SetActive(false);
    }
}
