using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Worldシーン　テキストに世代数と世代名を参照・表示するスクリプト
/// テキストオブジェクト　LastNameにアタッチ
/// </summary>

public class LastName_text : MonoBehaviour
{

    public Text LastName;

    // Use this for initialization
    void Start()
    {
        LastName.text = "第" + PlayerStatus.geneNumber + "世代" + PlayerStatus.clanName + "家";
    }
}
