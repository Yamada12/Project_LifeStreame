using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Novel;

public class SceneChanger : MonoBehaviour
{
    public void ChangeUnityScene(string sceneName)
    {//UnityからUnityのシーンへ遷移
        //Application.LoadLevel(sceneName);
        PlayerStatus.static_Load();
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeJokerScene(string sceneName)
    {//UnityからJokerのシーンへ遷移
        PlayerStatus.InitConverter();
        NovelSingleton.StatusManager.callJoker(sceneName, "");
        SoundPlayer.Instance.PlaySE("Event_Enter");
    }

    public void ChangeJokerScene_Love(string character)
    {
        float rnd = Random.Range(0, 4);
        SoundPlayer.Instance.PlaySE("Event_Enter");
        if (PlayerStatus.lifeTime > 20)
        {
            PlayerStatus.lifeTime -= 20;
            switch (character)
            {
                case "tun"://ツンデレ
                    if (rnd == 0)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/Eiga_tun", "");
                    }
                    else if (rnd == 1)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/Kaimono_tun", "");
                    }
                    else if (rnd == 2)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/Kouen_tun", "");
                    }
                    else if (rnd == 3)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/Suizoku_tun", "");
                    }
                    break;
                case "majime"://真面目
                    if (rnd == 0)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/Eiga_majime", "");
                    }
                    else if (rnd == 1)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/Kaimono_majime", "");
                    }
                    else if (rnd == 2)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/Kouen_majime", "");
                    }
                    else if (rnd == 3)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/Suizoku_majime", "");
                    }
                    break;
                case "supokon"://スポコン
                    if (rnd == 0)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/Eiga_supo", "");
                    }
                    else if (rnd == 1)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/Kaimono_supo", "");
                    }
                    else if (rnd == 2)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/Kouen_supo", "");
                    }
                    else if (rnd == 3)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/Suizoku_supo", "");
                    }
                    break;
                case "mega"://インテリメガネ
                    if (rnd == 0)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/Eiga_interi", "");
                    }
                    else if (rnd == 1)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/Kaimono_interi", "");
                    }
                    else if (rnd == 2)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/Kouen_interi", "");
                    }
                    else if (rnd == 3)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/Suizoku_interi", "");
                    }
                    break;
                case "kamase"://カマセ
                    if (rnd == 0)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/Eiga_kamase", "");
                    }
                    else if (rnd == 1)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/Kaimono_kamase", "");
                    }
                    else if (rnd == 2)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/Kouen_kamase", "");
                    }
                    else if (rnd == 3)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/Suizoku_kamase", "");
                    }
                    break;
                case "nago"://和やか
                    if (rnd == 0)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/Eiga_nagoyaka", "");
                    }
                    else if (rnd == 1)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/Kaimono_nagoyaka", "");
                    }
                    else if (rnd == 2)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/Kouen_nagoyaka", "");
                    }
                    else if (rnd == 3)
                    {
                        PlayerStatus.InitConverter();
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/Suizoku_nagoyaka", "");
                    }
                    break;
                case "tun_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/Kokuhaku_tun", "");
                    break;
                case "majime_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/Kokuhaku_majime", "");
                    break;
                case "supokon_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/Kokuhaku_supo", "");
                    break;
                case "mega_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/Kokuhaku_interi", "");
                    break;
                case "kamase_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/Kokuhaku_kamase", "");
                    break;
                case "nago_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/Kokuhaku_nagoyaka", "");
                    break;
                default:
                    break;
            }
        }
    }

    public void ChangeJokerScene_Love_After(string character)
    {
        if (PlayerStatus.lifeTime > 20)
        {
            PlayerStatus.lifeTime -= 20;
            switch (character)
            {
                case "tun"://ツンデレ
                    if (PlayerStatus.love_AfterCount == 0)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/after1_tun", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 1)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/after2_tun", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 2)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        GameObject.Find("Propose").GetComponent<Button>().interactable = true;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/after3_tun", "");
                    }
                    break;
                case "majime"://真面目
                    if (PlayerStatus.love_AfterCount == 0)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/after1_majime", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 1)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/after2_majime", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 2)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        GameObject.Find("Propose").GetComponent<Button>().interactable = true;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/after3_majime", "");
                    }
                    break;
                case "supokon"://スポコン
                    if (PlayerStatus.love_AfterCount == 0)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/after1_supo", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 1)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/after2_supo", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 2)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        GameObject.Find("Propose").GetComponent<Button>().interactable = true;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/after3_supo", "");
                    }
                    break;
                case "mega"://インテリメガネ
                    if (PlayerStatus.love_AfterCount == 0)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/after1_interi", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 1)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/after2_interi", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 2)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        GameObject.Find("Propose").GetComponent<Button>().interactable = true;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/after3_interi", "");
                    }
                    break;
                case "kamase"://カマセ
                    if (PlayerStatus.love_AfterCount == 0)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/after1_kamase", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 1)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/after2_kamase", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 2)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        GameObject.Find("Propose").GetComponent<Button>().interactable = true;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/after3_kamase", "");
                    }
                    break;
                case "nago"://和やか
                    if (PlayerStatus.love_AfterCount == 0)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/after1_nagoyaka", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 1)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/after2_nagoyaka", "");
                    }
                    else if (PlayerStatus.love_AfterCount == 2)
                    {
                        PlayerStatus.InitConverter();
                        PlayerStatus.love_AfterCount += 1;
                        GameObject.Find("Propose").GetComponent<Button>().interactable = true;
                        NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/after3_nagoyaka", "");
                    }
                    break;
                case "tun_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/F/Tundere/Puropozu_tun", "");
                    break;
                case "majime_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/F/Majime/Puropozu_majime", "");
                    break;
                case "supokon_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/F/Supokon/Puropozu_supo", "");
                    break;
                case "mega_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/M/Interi/Puropozu_interi", "");
                    break;
                case "kamase_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/M/Kamase/Puropozu_kamase", "");
                    break;
                case "nago_con":
                    PlayerStatus.InitConverter();
                    NovelSingleton.StatusManager.callJoker("wide/Renai/M/Nagoyaka/Puropozu_nagoyaka", "");
                    break;
                default:
                    break;
            }
        }
    }
}