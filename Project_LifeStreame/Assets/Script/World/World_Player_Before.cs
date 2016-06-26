using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　Player01の移動を制御するスクリプト　試験前
///　オブジェクト　Player01にアタッチ
/// </summary>

public class World_Player_Before : MonoBehaviour
{

    void Start()//試験前　真上にぴょん
    {
        if (World_Player.shiken == 0)
        {
            iTween.MoveTo(gameObject, iTween.Hash("delay", 2.0f, "y", 1.5, "time", 0.3f, "oncomplete", "Move1", "oncompletetarget", gameObject));
        }

    }

    public void Move1()//まっすぐびゅーん
    {
        
        iTween.MoveBy(gameObject, iTween.Hash("delay", 0.5f, "z", 15, "time", 0.5f, "oncomplete", "Move2", "oncompletetarget", gameObject));

        if (PlayerStatus.progress == 7 || PlayerStatus.progress == 8)//社会人・年寄りはまっすぐびゅーーーーん
        {
            iTween.MoveBy(gameObject, iTween.Hash("delay", 0.5f, "z", 50, "time", 10.0f));
        }

    }

    public void Move2()//下にすたっと
    {
        {
            iTween.MoveTo(gameObject, iTween.Hash("delay", 0.5f, "y", -0.5, "time", 0.3f));
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (World_Player.kanban_shiken == 1 && World_Player.Select_Button == 0)
        {
            if (Input.GetMouseButton(0))//クリックで試験シーンに飛び込む
            {
                iTween.MoveBy(gameObject, iTween.Hash("z", 5, "y", 1));
                //iTween.RotateBy(gameObject, iTween.Hash("z", 0.05));
                World_Player.kanban_shiken = 99;
                World_Player.Select_Button = 99;
            }
        }

        if (World_Player.Select_Button == 1)
        {
            if (World_SelectButton.Life >= 1)
            {//上にぴょん
                iTween.MoveBy(gameObject, iTween.Hash("y", 1, "time", 0.2, "oncomplete", "Select_move", "oncompletetarget", gameObject));
                World_Player.Select_Button = 99;
            }
        }

    }

    public void Select_move()
    {//まっすぐびゅーん
        iTween.MoveBy(gameObject, iTween.Hash("z", 13, "time", 0.5, "oncomplete", "Select_move2", "oncompletetarget", gameObject));
    }

    public void Select_move2()
    {//下にすたっと
        iTween.MoveBy(gameObject, iTween.Hash("y", -1, "time", 0.2));
    }
}
