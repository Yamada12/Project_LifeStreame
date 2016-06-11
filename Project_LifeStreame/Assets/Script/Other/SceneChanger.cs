using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Novel;

public class SceneChanger : MonoBehaviour
{
    public void ChangeUnityScene(string sceneName)
    {//UnityからUnityのシーンへ遷移
        //Application.LoadLevel(sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeJokerScene(string sceneName)
    {//UnityからJokerのシーンへ遷移
        PlayerStatus.InitConverter();
        NovelSingleton.StatusManager.callJoker(sceneName, "");
    }

    public void ChangeJokerScene_Love(string character)
    {
        float rnd = Random.Range(0, 4);

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
