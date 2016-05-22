using UnityEngine;
using System.Collections;

public class Scenechange : MonoBehaviour {
    public string nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Click()
    {
        Application.LoadLevel(nextScene);
    }
}
