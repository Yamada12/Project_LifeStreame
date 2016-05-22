using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

public class World_turningPoint : MonoBehaviour {

    public GameObject image01;
    public GameObject image02;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(World_Player.UI01 == 1)
        {
            iTween.ScaleTo(image01, iTween.Hash("x", 1,"y", 1, "time", 3.0f));
        }
        if(World_Player.UI01 == 0)
        {
            iTween.ScaleTo(image01, iTween.Hash("x", 0, "y", 0, "time", 3.0f));
        }

        if(World_Player.UI02 == 1)
        {
            iTween.ScaleTo(image02, iTween.Hash("x", 1, "y", 1, "time", 3.0f));
        }
        if(World_Player.UI02 == 0)
        {
            iTween.ScaleTo(image02, iTween.Hash("x", 0, "y", 0, "time", 3.0f));
        }
	
	}
}
