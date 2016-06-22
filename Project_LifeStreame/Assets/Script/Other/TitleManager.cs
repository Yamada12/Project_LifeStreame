using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject titleObject = null;
    public GameObject startButton = null;
    public GameObject continueButton = null;

    public GameObject warningPanel = null;

    // Use this for initialization
    void Start ()
    {
        SoundPlayer.Instance.PlayBGM("title");
        close();
    }

    public void StartGame()
    {
        if (PlayerPrefs.HasKey("mf"))//mfキーがあったら
        {
            warningPanel.SetActive(true);
            warningPanel.GetComponentInChildren<Text>().text = "前回のプレイデータが残っています！\n初めから開始してもよろしいですか？";
        }
        else
            ChangeScene("First_Setting");
    }

    public void close()
    {//Warningのパネル
       warningPanel.SetActive(false);
    }

    void ChangeScene(string sceneName)
    {//シーン遷移メソッド(このスクリプトだけのメソッド)
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
