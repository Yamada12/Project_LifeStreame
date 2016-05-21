﻿using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour
{
    static public int mf;          //性別　0＝男性　1=女性
    static public string clanName;  //一族の名前
    static public float paramater1; //～の数値
    static public float paramater2; //～の数値
    static public float paramater3; //～の数値
    static public float paramater4; //～の数値
    static public float paramater5; //～の数値
    static public float geneNumber; //世代数
    static public string[] license; //資格名
    static public float lifeTime;   //残り時間
    static public int progress;     //進行度   小学校＝１　2年生＝２　etc...
    static public string job;       //ジョブ名（職業名）
    static public int marriage;    //結婚しているかどうか？　0＝結婚している　1=結婚してない
    static public int children;     //子供の人数（双子かどうか？）
    static public int schoolFlag;   //所属学校（０なら無所属、１なら？？学校　etc...）
    static public int clubFlag;     //部活動は何系か？　0＝文化　1＝運動　2=無所属
    static public int courseYear;   //経過年数（現在の進行度に何年滞在したか？※学年など）


    // Use this for initialization
    static public void initStatus ()
    {//はじめから開始時にすべての変数をリセットするメソッド
        mf = 0;  //入力なしの場合は男性になる
        clanName = "佐々木";   //入力なしの場合は佐々木になる
        paramater1 = 0;
        paramater2 = 0;
        paramater3 = 0;
        paramater4 = 0;
        paramater5 = 0;
        geneNumber = 0;         //世代数
        /*license[0] = "無資格";
        for (int i = 0; i < license.Length; i++)
        {//資格の初期化
            license[i] = "無資格";
        }*/
        lifeTime = 180f;      //仮代入、一番初めに使う値をいれる
        progress = 0;
        job = "無職";         //暫定無職、小学生とかいれてもいいかも？
        marriage = 0;    //生まれながら結婚している奴などいない！
        children = 1;        //残機的な扱いのつもり（０でゲームオーバー的な）
        schoolFlag = 0;      //0=無所属
        clubFlag = 2;       //初期は無所属なので２
        courseYear = 1;      //経過年数なので初期値は１年目
    }

    public void DebugButton()
    {//デバッグ用ボタン用
        Debug.Log("ClanName is…" + clanName);
        Debug.Log("mf is…" + mf);
    }

    static public void GetConverter()
    {//Jokerから変数を受け取る
        /*
        mf = int.Parse(StatusManager.variable.get("f.mf"));
        clanName = StatusManager.variable.get("f.clanName");
        paramater1 = float.Parse(StatusManager.variable.get("f.paramater1"));
        paramater2 = float.Parse(StatusManager.variable.get("f.paramater2"));
        paramater3 = float.Parse(StatusManager.variable.get("f.paramater3"));
        paramater4 = float.Parse(StatusManager.variable.get("f.paramater4"));
        paramater5 = float.Parse(StatusManager.variable.get("f.paramater5"));
        geneNumber = float.Parse(StatusManager.variable.get("f.geneNumber"));
        lifeTime = float.Parse(StatusManager.variable.get("f.lifeTime"));
        progress = int.Parse(StatusManager.variable.get("f.progress"));
        job = StatusManager.variable.get("f.job");
        marriage = int.Parse(StatusManager.variable.get("f.marriage"));
        children = int.Parse(StatusManager.variable.get("f.children"));
        schoolFlag = int.Parse(StatusManager.variable.get("f.schoolFlag"));
        clubFlag = int.Parse(StatusManager.variable.get("f.clubFlag"));
        courseYear = int.Parse(StatusManager.variable.get("f.couceYear"));
        */
    }

    static public void InitConverter()
    {//Jokerに変数を受け渡す
        /*
        StatusManager.variable.set("f.mf", ((int)mf).ToString());
        StatusManager.variable.set("f.clanName", clanName.ToString());
        StatusManager.variable.set("f.paramater1", ((float)paramater1).ToString());
        StatusManager.variable.set("f.paramater2", ((float)paramater2).ToString());
        StatusManager.variable.set("f.paramater3", ((float)paramater3).ToString());
        StatusManager.variable.set("f.paramater4", ((float)paramater4).ToString());
        StatusManager.variable.set("f.paramater5", ((float)paramater5).ToString());
        StatusManager.variable.set("f.geneNumber", ((float)geneNumebr).ToString());
        StatusManager.variable.set("f.lifeTime", ((float)lifeTime).ToString());
        StatusManager.variable.set("f.progress", ((int)progress).ToString());
        StatusManager.variable.set("f.job", job.ToString());
        StatusManager.variable.set("f.marriage", ((int)marriage).ToString());
        StatusManager.variable.set("f.children", ((int)children).ToString());
        StatusManager.variable.set("f.schoolFlag", ((int)schoolFlag).ToString());
        StatusManager.variable.set("f.clubFlag", ((int)clubFlag).ToString());
        StatusManager.variable.set("f.courceYear", ((int)courseYear).ToString());
        */
    }
}