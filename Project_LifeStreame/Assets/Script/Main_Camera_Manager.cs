using UnityEngine;
using System.Collections;

public class Main_Camera_Manager : MonoBehaviour
{
    public GameObject originalObject;
    public GameObject[] targetObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void CameraMove(int point)
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 10f, "y", 10f, "z", 1f, "time", 0.5f));
        iTween.MoveTo(this.gameObject, iTween.Hash("x", targetObject[point - 1].transform.position.x, "y", targetObject[point - 1].transform.position.y, "z", targetObject[point - 1].transform.position.z, "time", 0.5f));
    }

    public void OriginalMove()
    {
        iTween.ScaleTo(this.gameObject, iTween.Hash("x", 1f, "y", 1f, "z", 1f, "time", 0.5f));
        iTween.MoveTo(this.gameObject, iTween.Hash("position", originalObject.transform.position, "time", 0.5f));
    }
}
