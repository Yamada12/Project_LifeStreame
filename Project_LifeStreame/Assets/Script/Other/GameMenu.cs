using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{

    public void GameMenuQuit(bool quit)
    {
        if (quit)
        {
            PlayerStatus.static_Save();
            Application.Quit();
        }
        else
        {
            PlayerStatus.static_Save();
            SceneManager.LoadScene("Title", LoadSceneMode.Single);
        }
    }

    public void Destroyer()
    {
        Destroy(this.gameObject);
    }
}
