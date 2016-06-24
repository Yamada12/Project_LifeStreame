using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public GameObject nameField;
    public GameObject m_Button;     //男性選択ボタン
    public GameObject f_Button;     //女性選択ボタン
    public Text finalAnswer;        //最終確認テキスト
    public Sprite[] selected_Sprite_m;
    public Sprite[] selected_Sprite_f;

    private string geneName;
    private int selectmf;

    // Use this for initialization
    void Start ()
    {
        SoundPlayer.Instance.PlayBGM("First01");
    }

    public void InputText()
    {
        string gender;
        if (selectmf == 0)
            gender = "男の子";
        else
            gender = "女の子";
        finalAnswer.text = "世代名:" + geneName + "\n性別:" + gender + "\nでよろしいですか？";
    }

    public void ClanInput()
    {//一族名登録
        geneName = nameField.GetComponent<InputField>().text;
        Debug.Log(PlayerStatus.clanName);
    }

    public void Mf_Select(int select)
    {//性別選択
        selectmf = select;
        if (select == 0)
        {//男性なら
            m_Button.GetComponent<Image>().sprite = selected_Sprite_m[0];
            f_Button.GetComponent<Image>().sprite = selected_Sprite_f[1];
            iTween.ScaleTo(m_Button, iTween.Hash("x", 1.5, "y", 1.5, "time", 1));
            iTween.ScaleTo(f_Button, iTween.Hash("x", 0.5, "y", 0.5, "time", 1));
        }
        else {
            f_Button.GetComponent<Image>().sprite = selected_Sprite_f[0];
            m_Button.GetComponent<Image>().sprite = selected_Sprite_m[1];
            iTween.ScaleTo(f_Button, iTween.Hash("x", 1.5, "y", 1.5, "time", 1));
            iTween.ScaleTo(m_Button, iTween.Hash("x", 0.5, "y", 0.5, "time", 1));
        }
        SoundPlayer.Instance.PlaySE("Maru");
    }

    public void save()
    {//セーブ
        PlayerStatus.initStatus();
        PlayerStatus.clanName = geneName;
        PlayerStatus.mf = selectmf;
        PlayerStatus.static_Save();
    }

    public void load()
    {//ロード
        PlayerStatus.static_Load();
    }

}
