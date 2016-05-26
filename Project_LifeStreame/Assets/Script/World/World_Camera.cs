using UnityEngine;
using System.Collections;

/// <summary>
/// Worldシーン Player01とMainCameraの親子関係を解除するスクリプト
/// カメラオブジェクト　Player01/MainCameraにアタッチ
/// </summary>

public class World_Camera : MonoBehaviour {

    public GameObject child;//子オブジェクト
    public Transform Camera_position;//カメラのポジション

	// Use this for initialization
	void Awake () {//Player01から親子関係を解除
        if(World_Player.UI02 == 1)
        {
            child.transform.parent = null;
        }

    }
	
	// Update is called once per frame
	void Update () {//カメラの位置をplayer01の真後ろに移動させる

        if(World_Player.UI02 == 1)
        {
            iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position, "time", 3.0f));
            iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position, "time", 3.0f));
        }

        
        
        

	
	}
}
