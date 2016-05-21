using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public GameObject UIControllerPref;
    GameObject UIController;
    public GameObject menuButton;
    public Text ButtonMessage;
    private bool click;
    private GameObject menu;

    // Update is called once per frame
    void Update()
    {
    }

    public void moveAnimation()
    {
        if (!click)
        {
            click = true;
            if (UIController == null)
            { //UIControllerが存在しなければ生成
                UIController = Instantiate(UIControllerPref) as GameObject;
            }
            ButtonMessage.text = "▲";
        } else {
            click = false;
            menuEnabled();
            ButtonMessage.text = "▼";
        }
    }

    void menuEnabled()
    {
        menu = GameObject.Find("menu_Canvas(Clone)");
        Destroy(menu.gameObject);
    }
}