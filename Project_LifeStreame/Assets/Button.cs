using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    public string nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Application.LoadLevel(nextScene);
    }
}
