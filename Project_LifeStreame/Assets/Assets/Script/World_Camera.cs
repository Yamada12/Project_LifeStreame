using UnityEngine;
using System.Collections;

public class World_Camera : MonoBehaviour {

    public GameObject child;
    public Transform Camera_position_ES;
    public Transform Camera_position_JHS;
    public Transform Camera_position_HS;
    public Transform Camera_position_PS;
    public Transform Camera_position_U;
    public Transform Camera_position_MOS;
    public Transform Camera_position_GA;

    // Use this for initialization
    void Awake () {
        if(World_Player.UI02 == 1)
        {
            child.transform.parent = null;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (World_Player.progress == 1)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_ES, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_ES, "time", 3.0f));
            }
        }

        if (World_Player.progress == 2)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_JHS, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_JHS, "time", 3.0f));
            }
        }

        if (World_Player.progress == 3)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_HS, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_HS, "time", 3.0f));
            }
        }

        if (World_Player.progress == 4)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_PS, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_PS, "time", 3.0f));
            }
        }

        if (World_Player.progress == 5)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_U, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_U, "time", 3.0f));
            }
        }

        if (World_Player.progress == 6)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_MOS, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_MOS, "time", 3.0f));
            }
        }

        if (World_Player.progress == 7)
        {
            if (World_Player.UI02 == 1)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position_GA, "time", 3.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position_GA, "time", 3.0f));
            }
        }






    }
}
