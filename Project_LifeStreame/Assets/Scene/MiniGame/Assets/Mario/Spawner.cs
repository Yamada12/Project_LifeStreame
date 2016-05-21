using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject Wall;
    public float interval;  //インターバル
    public float range = 2.0f;  //ふり幅

	IEnumerator Start () {
        while (true)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(0, range), transform.position.z); //y軸がランダム
            Instantiate(Wall, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }
	
	}

	void Update () {
	
	}
}
