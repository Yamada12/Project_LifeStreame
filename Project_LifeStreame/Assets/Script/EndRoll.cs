using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndRoll : MonoBehaviour
{
    public GameObject endPoint = null;
    public GameObject endRoll = null;

	// Use this for initialization
	void Start ()
    {
        SoundPlayer.Instance.PlayBGM("Endroll");
        endRoll = this.gameObject;
        PopTrophy.GetTrophy("あ～あ、やっちゃったね", "お迎えにあがられる", 19);
        //iTween.MoveTo(endRoll, iTween.Hash("position", endPoint.transform.position, "time", 10f, "oncomplete", "endGame", "oncompletetarget", this.gameObject));
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, 3 * Time.deltaTime, 0);
        Invoke("endGame", 30f);
	}

    void endGame()
    {
        PlayerStatus.initStatus();
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }

}
