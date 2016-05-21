using UnityEngine;
using System.Collections;

public class Spawnerg : MonoBehaviour {
   
    public float interval; //インターバル
    public float range = 2.0f; //ふり幅 
    public GameObject[] prefabs;
   // const int hcount = 3;
   // int count1;
    GameObject Enemy = null;
    IEnumerator Start()
    {
        while (true)
        {
            transform.position = new Vector3(Random.Range(-7, 10), Random.Range(-range, range), transform.position.z);
            int Ramd = Random.Range(0, prefabs.Length);
            Enemy = prefabs[Ramd];
            Instantiate(Enemy, transform.position, transform.rotation);
            yield return new WaitForSeconds(interval);
        }

    }
    
}
