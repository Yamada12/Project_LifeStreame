using UnityEngine;
using System.Collections;

/// <summary>
/// Worldシーン Player01とMainCameraの親子関係を解除するスクリプト
/// カメラオブジェクト　Player01/MainCameraにアタッチ
/// </summary>

public class World_Camera : MonoBehaviour {

    public GameObject child;//子オブジェクト
    public Transform Camera_position;//カメラのポジション
	
	// Update is called once per frame
	void Update () {//カメラの動作制御

        if(World_Player.kanban_nyugaku == 1 || World_Player.Select_Button == 1 || World_Player.kanban_toshiyori == 1 || World_Player.kanban_shakai == 1)
        {//カメラの位置をplayer01の真後ろに移動させる
            iTween.MoveTo(gameObject, iTween.Hash("position", Camera_position, "time", 1.0f, "oncomplete", "", "oncompletetarget", gameObject));
            iTween.RotateTo(gameObject, iTween.Hash("rotation", Camera_position, "time", 1.0f));
            World_Player.kanban_nyugaku = 2;
        }

        if(World_Player.kanban_shakai == 1)
        {
            World_Player.kanban_shakai = 2;
        }

        if(World_Player.kanban_toshiyori == 1)
        {
            World_Player.kanban_toshiyori = 2;
        }

        if (World_Player.kanban_nyugaku == 2 || World_Player.Select_Button == 3 || World_Player.kanban_toshiyori == 2 || World_Player.kanban_shakai == 2)
        {//親子関係解除
            child.transform.parent = null;
        }






    }
}
