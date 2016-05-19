using UnityEngine;
using System.Collections;

public class SaveSystem : MonoBehaviour
{
    static public void static_Save()
    {
        PlayerPrefs.SetString("clanName", PlayerStatus.clanName);
        PlayerPrefs.SetInt("mf", PlayerStatus.mf);
    }

    static public void static_Load()
    {
        PlayerStatus.clanName = PlayerPrefs.GetString("clanName");
        PlayerStatus.mf = PlayerPrefs.GetInt("mf");
    }


}
