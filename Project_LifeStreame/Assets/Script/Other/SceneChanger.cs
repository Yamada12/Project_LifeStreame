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
        NovelSingleton.StatusManager.callJoker(sceneName, "");
    }
}
