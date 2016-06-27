using UnityEngine;
using System.Collections;

public class InitScene : MonoBehaviour
{
    public GameObject[] scenePrefabs;

	// Use this for initialization
	void Start ()
    {
        if (PlayerStatus.progress >= 4)
        {
            if (World_Player.result >= 9)
            {//やばいパート
                GameObject scene = Instantiate(scenePrefabs[PlayerStatus.progress - 2 + 12]) as GameObject;
                Debug.Log("生成されたシーン名:" + scene.name + "現在の進行度:" + PlayerStatus.progress + "ここはやばい所だ");
            }
            else if (World_Player.result >= 7)
            {//ふつうパート
                GameObject scene = Instantiate(scenePrefabs[PlayerStatus.progress - 2 + 6]) as GameObject;
                Debug.Log("生成されたシーン名:" + scene.name + "現在の進行度:" + PlayerStatus.progress + "ここは普通の所だ");
            }
            else if (World_Player.result <= 5)
            {//しょぼいパート
                GameObject scene = Instantiate(scenePrefabs[PlayerStatus.progress - 2]) as GameObject;
                Debug.Log("生成されたシーン名:" + scene.name + "現在の進行度:" + PlayerStatus.progress + "ここはしょぼい所だ");
            }
        }
        else
        {
            if (World_Player.result >= 9)
            {//やばいパート
                GameObject scene = Instantiate(scenePrefabs[PlayerStatus.progress - 1 + 12]) as GameObject;
                Debug.Log("生成されたシーン名:" + scene.name + "現在の進行度:" + PlayerStatus.progress + "ここはやばい所だ");
                if(scene.name == "Main_Pro(Clone)")
                    PopTrophy.GetTrophy("専門デビュー", "専門学校に進学した", 16);
                else if(scene.name == "Main_Col(Clone)")
                    PopTrophy.GetTrophy("大学デビュー", "大学に進学した", 17);
            }
            else if (World_Player.result >= 7)
            {//ふつうパート
                GameObject scene = Instantiate(scenePrefabs[PlayerStatus.progress - 1 + 6]) as GameObject;
                Debug.Log("生成されたシーン名:" + scene.name + "現在の進行度:" + PlayerStatus.progress + "ここは普通の所だ");
                if (scene.name == "Main_Pro(Clone)")
                    PopTrophy.GetTrophy("専門デビュー", "専門学校に進学した", 16);
                else if (scene.name == "Main_Col(Clone)")
                    PopTrophy.GetTrophy("大学デビュー", "大学に進学した", 17);
            }
            else if (World_Player.result <= 5)
            {//しょぼいパート
                GameObject scene = Instantiate(scenePrefabs[PlayerStatus.progress - 1]) as GameObject;
                Debug.Log("生成されたシーン名:" + scene.name + "現在の進行度:" + PlayerStatus.progress + "ここはしょぼい所だ");
                if (scene.name == "Main_Pro(Clone)")
                    PopTrophy.GetTrophy("専門デビュー", "専門学校に進学した", 16);
                else if (scene.name == "Main_Col(Clone)")
                    PopTrophy.GetTrophy("大学デビュー", "大学に進学した", 17);
            }
        }
	}
}
