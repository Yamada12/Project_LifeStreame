using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

public class World_ShikenIkon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        iTween.RotateBy(gameObject, iTween.Hash("y", 1));
    }
}
