using UnityEngine;
using System.Collections;

public class Kanban : MonoBehaviour {

    public Transform kanbanPosition;
    public GameObject shoboi;
    public GameObject hutuu;
    public GameObject yabai;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (gameObject == shoboi)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", kanbanPosition, "time", 1.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", kanbanPosition, "time", 1.0f));
            }

            if (gameObject == hutuu)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", kanbanPosition, "time", 1.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", kanbanPosition, "time", 1.0f));
            }

            if (gameObject == yabai)
            {
                iTween.MoveTo(gameObject, iTween.Hash("position", kanbanPosition, "time", 1.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", kanbanPosition, "time", 1.0f));
            }
        }
    }
}
