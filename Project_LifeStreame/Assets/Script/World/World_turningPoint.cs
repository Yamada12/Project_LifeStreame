using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　試験前・試験後のイメージを表示するスクリプト
/// イメージオブジェクト　UICamera/Canvas/turningpointにアタッチ
/// </summary>

public class World_turningPoint : MonoBehaviour {

    public GameObject image01;//試験前表示イメージ
    public GameObject image02;//試験後表示イメージ
	
	// Update is called once per frame
	void Update () {//イメージ表示を判定する
        if(World_Player.UI01 == 1)
        {
            iTween.ScaleTo(image01, iTween.Hash("x", 1,"y", 1, "time", 3.0f));
        }

        if(World_Player.UI02 == 1)
        {
            iTween.ScaleTo(image02, iTween.Hash("x", 1, "y", 1, "time", 3.0f));
        }
	
	}
}
