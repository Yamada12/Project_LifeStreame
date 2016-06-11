using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public GameObject nameField;

	// Use this for initialization
	void Start ()
    {
        PlayerStatus.initStatus();
	}

    public void ClanInput()
    {//一族名登録
        PlayerStatus.clanName = nameField.GetComponent<InputField>().text;
        Debug.Log(PlayerStatus.clanName);
    }

    public void Mf_Select(int select)
    {//性別選択
        PlayerStatus.mf = select;
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
