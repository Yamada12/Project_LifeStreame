using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public float speed;

    void Start()
    {
        Destroy(gameObject,15f);
    }

    void Update()
    {

        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
