using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject Wall;
    public float interval;	
	IEnumerator Start () {
        while (true)
        {
            Instantiate(Wall, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
