using UnityEngine;
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
        license[0] = "無資格"; //初めの資格が無資格ならその後の資格は探索されないようにしてください。
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

}
