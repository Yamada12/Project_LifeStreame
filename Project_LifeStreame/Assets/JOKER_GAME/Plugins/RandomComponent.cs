using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Novel
{

    public class RandomComponent : AbstractComponent
    {
        public RandomComponent()
        {

            //必須項目
            this.arrayVitalParam = new List<string> {
                "var","num"
            };

            this.originalParam = new Dictionary<string, string>() {
                {"var",""},
                {"num",""},
            };

        }


        public override void start()
        {

            string var_name = this.param["var"];
            int arg1 = int.Parse(this.param["num"]);

            System.Random rnd = new System.Random();
            string randomNumber = "" + rnd.Next(arg1);

            //変数に結果を格納
            StatusManager.variable.set(var_name, randomNumber);


            //次のシナリオに進む処理
            this.gameManager.nextOrder();

        }

    }

}