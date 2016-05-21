using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

    public float speed;
	
    void Start()
    {
        Destroy(gameObject, 5f);
    }
	
	void Update () {

        transform.Translate(speed * Time.deltaTime, 0, 0);
	
	}
}
