using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public GameObject nameField;
    public GameObject m_Button;     //男性選択ボタン
    public GameObject f_Button;     //女性選択ボタン

	// Use this for initialization
	void Start ()
    {
        PlayerStatus.initStatus();
        SoundPlayer.Instance.PlayBGM("First01");
    }

    public void ClanInput()
    {//一族名登録
        PlayerStatus.clanName = nameField.GetComponent<InputField>().text;
        Debug.Log(PlayerStatus.clanName);
    }

    public void Mf_Select(int select)
    {//性別選択
        PlayerStatus.mf = select;
        if (select == 0)
        {//男性なら
            iTween.ScaleTo(m_Button, iTween.Hash("x", 1.5, "y", 1.5, "time", 1));
            iTween.ScaleTo(f_Button, iTween.Hash("x", 0.5, "y", 0.5, "time", 1));
        }
        else {
            iTween.ScaleTo(f_Button, iTween.Hash("x", 1.5, "y", 1.5, "time", 1));
            iTween.ScaleTo(m_Button, iTween.Hash("x", 0.5, "y", 0.5, "time", 1));
        }
        SoundPlayer.Instance.PlaySE("Normal_Enter");
    }

    public void save()
    {//セーブ
        PlayerStatus.static_Save();
    }

    public void load()
    {//ロード
        PlayerStatus.static_Load();
    }

}
