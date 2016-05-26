using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// WorldシーンのUIを管理するスクリプト
/// リストに値を加える。
/// </summary>
public class World_UI : MonoBehaviour {

    public GUIStyle Box;
    public GUIStyle Text;
    public GUIStyle Button;
    //private string clanName = PlayerStatus.clanName;
    //private float geneNumber = PlayerStatus.geneNumber;

    // Use this for initialization
    void Start () {//世代数と名前を参照する
        PlayerStatus.initStatus();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnGUI () {//プレイヤーの基本情報表示(世代数、名前)
        GUI.skin.textField.fontSize = 35;
        GUI.skin.box.fontSize = 50;
        GUI.skin.button.fontSize = 30;

        //第〇世代〇〇家
        GUI.Box(new Rect(Screen.width / 2 - 550, Screen.height / 2 - 300, 500, 100), "",Box);
        GUI.TextArea(new Rect(Screen.width / 2 - 500, Screen.height / 2 - 280, 500, 100),"第" + PlayerStatus.geneNumber + "世代" + PlayerStatus.clanName + "家", Text);
        
        
    }


}
