using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {

        transform.Translate(speed * Time.deltaTime, 0, 0);
	
	}
}
