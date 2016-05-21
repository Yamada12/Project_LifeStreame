using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContentManager : MonoBehaviour
{
    public GameObject[] targetContent;
    public GameObject basePoint;

	// Use this for initialization
	void Start ()
    {	
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

    public void OpenContent()
    {
        this.gameObject.SetActive(false);

        for (int i = 0; i < targetContent.Length; i++)
        {
            targetContent[i].SetActive(true);

            iTween.ScaleFrom(targetContent[i], iTween.Hash("x", 0.1f, "y", 0.1f, "z", 0.1f, "time", 0.5f));
            iTween.MoveFrom(targetContent[i], iTween.Hash("position", basePoint.gameObject.transform.position, "time", 0.5f));
        }
    }
}
