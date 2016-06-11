using UnityEngine;
using System.Collections;

public class World_SelectButton : MonoBehaviour {

    public int Select;
    static public int Life;
    public GameObject kabe;

    void Start()
    {
        kabe.SetActive(false);
        Life = 0;
    }

    public void OnClick()
    {
        switch (Select)
        {
            case 0:
                Life = 1;
                break;
            case 1:
                Life = 2;
                break;
            case 2:
                Life = 3;
                break;
            default:
                break;
        }
        Invoke("Click_After", 0);


    }

    public void Click_After()
    {
        if (Life >= 1)
        {
            kabe.SetActive(true);
        }
    }
}
