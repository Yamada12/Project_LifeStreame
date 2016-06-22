using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class charaChanger : MonoBehaviour
{
    public Sprite[] differenceAll;  //差分
    public Image charaCanvas;
    private int num = 0;

    public void Selecter(bool left)
    {
        if (left)
        {
            num += 1;
            if (num >= differenceAll.Length)
                num = 0;
        } else {
            num -= 1;
            if (num <= -1)
                num = differenceAll.Length - 1;
        }

        charaCanvas.sprite = differenceAll[num];
        SoundPlayer.Instance.PlaySE("Normal_Enter");
    }
}
