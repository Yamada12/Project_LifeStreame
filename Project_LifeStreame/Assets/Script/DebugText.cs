using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DebugText : MonoBehaviour
{
    public Text debugText;

	// Use this for initialization
	void Start ()
    {
        debugText.text = "debugMode";
	}
	
	// Update is called once per frame
	void Update ()
    {
        debugText.text = "真面目ちゃん:" + PlayerStatus.lp_maji;
	}
}
