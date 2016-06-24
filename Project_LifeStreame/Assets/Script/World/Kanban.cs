using UnityEngine;
using System.Collections;

/// <summary>
/// 看板を制御するスクリプト
/// </summary>

public class Kanban : MonoBehaviour {

    public Transform kanbanPosition;
    public int Kanban_num;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")//プレイヤーが看板に触れたら上にボーンッ！
        {
                iTween.MoveTo(gameObject, iTween.Hash("position", kanbanPosition, "time", 1.0f));
                iTween.RotateTo(gameObject, iTween.Hash("rotation", kanbanPosition, "time", 1.0f));

            if (Kanban_num == 1)//看板しょぼいの時のSE
            {

            }

            if (Kanban_num == 2)//看板ふつうの時のSE
            {

            }

            if (Kanban_num == 3)//看板やばいの時のSE
            {

            }
        }
    }
}
