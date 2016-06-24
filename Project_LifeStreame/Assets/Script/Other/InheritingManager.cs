using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InheritingManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        PlayerStatus.static_Save();
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    public void InheritingNewGame()
    {
        PlayerStatus.InitInheriting();
        SceneManager.LoadScene("World");
    }

    public void InheritingTitle()
    {
        PlayerStatus.InitInheriting();
        SceneManager.LoadScene("Title");
    }
}
