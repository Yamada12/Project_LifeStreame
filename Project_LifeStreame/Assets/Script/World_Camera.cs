using UnityEngine;
using System.Collections;

public class World_Camera : MonoBehaviour {

    public GameObject child;
    public Transform Camera_position;

	// Use this for initialization
	void Awake () {
        if(World_Player.UI02 == 1)
        {
            child.transform.parent = null;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if(World_Player.UI02 == 1)
        {
            iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position, "time", 3.0f));
            iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position, "time", 3.0f));
        }

        
        
        

	
	}
}
