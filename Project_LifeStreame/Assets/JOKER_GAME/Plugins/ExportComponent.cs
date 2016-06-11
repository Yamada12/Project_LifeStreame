using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Novel
{

    public class ExportComponent : AbstractComponent
    {
        public override void start()
        {

            PlayerStatus.co = float.Parse(StatusManager.variable.get("f.co"));
            PlayerStatus.ec = float.Parse(StatusManager.variable.get("f.ec"));
            PlayerStatus.ac = float.Parse(StatusManager.variable.get("f.ac"));
            PlayerStatus.hu = float.Parse(StatusManager.variable.get("f.hu"));
            PlayerStatus.vi = float.Parse(StatusManager.variable.get("f.vi"));
            PlayerStatus.lu = float.Parse(StatusManager.variable.get("f.lu"));

            PlayerStatus.lp_tun = int.Parse(StatusManager.variable.get("f.lp_tun"));
            PlayerStatus.lp_maji = int.Parse(StatusManager.variable.get("f.lp_maji"));
            PlayerStatus.lp_supo = int.Parse(StatusManager.variable.get("f.lp_supo"));
            PlayerStatus.lp_hika = int.Parse(StatusManager.variable.get("f.lp_hika"));
            PlayerStatus.lp_ten = int.Parse(StatusManager.variable.get("f.lp_ten"));

            PlayerStatus.lp_mega = int.Parse(StatusManager.variable.get("f.lp_mega"));
            PlayerStatus.lp_kama = int.Parse(StatusManager.variable.get("f.lp_kama"));
            PlayerStatus.lp_nago = int.Parse(StatusManager.variable.get("f.lp_nago"));
            PlayerStatus.lp_ore = int.Parse(StatusManager.variable.get("f.lp_ore"));
            PlayerStatus.lp_ani = int.Parse(StatusManager.variable.get("f.lp_ani"));

            //次のシナリオに進む処理
            this.gameManager.nextOrder();

        }

    }

}