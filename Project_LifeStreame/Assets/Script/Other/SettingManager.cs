using UnityEngine;
using System.Collections;

public class SettingManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        PlayerStatus.static_Load();
	}

    public void ClanInput(string name)
    {//一族名登録
        PlayerStatus.clanName = name;
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
