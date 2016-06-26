using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　Player01の移動を制御するスクリプト　試験後
///　オブジェクト　Player01にアタッチ
/// </summary>

public class World_Player_After : MonoBehaviour
{
    //static public int progress;//デバック用変数

    void Start()//試験後上にぴょん
    {

        if (World_Player.shiken == 1)
        {
            Debug.Log("リザルト"+ World_Player.result);
            iTween.MoveTo(gameObject, iTween.Hash("delay", 0.5f, "y", 0.5, "time", 0.2f, "oncomplete", "Move4", "oncompletetarget", gameObject));
        }
    }

    public void Move4()//前にブーン
    {
        iTween.MoveBy(gameObject, iTween.Hash("z", 3, "time", 0.3f, "oncomplete", "Move5", "oncompletetarget", gameObject));
    }

    public void Move5()//下にすたっ
    {
        iTween.MoveBy(gameObject, iTween.Hash("y", -0.5, "time", 0.2f, "oncomplete", "Update", "oncompletetarget", gameObject));
    }

    void Update()
    {
        if (World_Player.shiken == 1)//試験後、クリックで
        {
            if (World_Player.kanban_nyugaku == 2 || World_Player.kanban_shakai == 1)
            {
                if (Input.GetMouseButton(0))
                {
                    iTween.MoveBy(gameObject, iTween.Hash("y", 0.5, "time", 0.2f, "oncomplete", "Move7", "oncompletetarget", gameObject));
                    World_Player.kanban_nyugaku = 3;
                    World_Player.kanban_shakai = 2;
                    World_Player.clickHappy = 1;
                }
            }
        }

        if (World_Player.Select_Button == 2)//人生の選択後、
        {
            iTween.MoveBy(gameObject, iTween.Hash("y", 0.5, "time", 0.2f, "oncomplete", "Move7", "oncompletetarget", gameObject));
            World_Player.Select_Button = 99;
        }



    }

    public void Move7()
    {

        Debug.Log("リザルト"+World_Player.result);//リザルトが0になってしまう？

        switch (World_Player.result)
        {
            case 3:
                iTween.MoveBy(gameObject, iTween.Hash("z", 20, "x", 20, "time", 3f));
                break;
            case 5:
                iTween.MoveBy(gameObject, iTween.Hash("z", 20, "x", 20, "time", 3f));
                break;
            case 7:
                iTween.MoveBy(gameObject, iTween.Hash("z", 20, "time", 3f));
                break;
            case 9:
                iTween.MoveBy(gameObject, iTween.Hash("z", 20, "x", -20, "time", 3f));
                break;
            default:
                break;
        }

        if (World_SelectButton.Life >= 1)//人生の選択肢、ルート決め
        {
            World_Player.Select_Button = 3;//Camera 親子解除

            switch (World_SelectButton.Life)
            {
                case 1:
                    iTween.MoveBy(gameObject, iTween.Hash("z", 20, "x", -20, "time", 3f));
                    break;
                case 2:
                    iTween.MoveBy(gameObject, iTween.Hash("z", 20, "time", 3f));
                    break;
                case 3:
                    iTween.MoveBy(gameObject, iTween.Hash("z", 20, "x", 20, "time", 3f));
                    break;
                default:
                    break;
            }
        }
    }
}