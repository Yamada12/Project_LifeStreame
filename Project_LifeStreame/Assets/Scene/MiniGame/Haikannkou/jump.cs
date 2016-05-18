using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

    public float jumpP;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpP, 0);
        }
	
	}
}
