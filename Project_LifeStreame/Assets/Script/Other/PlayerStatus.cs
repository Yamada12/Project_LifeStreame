using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;

/// <summary>
/// ユーザーの情報を管理するスクリプト
/// </summary>
public class PlayerStatus : MonoBehaviour
{
    static public int mf;          //性別　0＝男性　1=女性
    static public string clanName;  //一族の名前
    static public float co; //コミュ力の数値
    static public float ec; //経済力の数値
    static public float ac; //学力の数値
    static public float hu; //人間力の数値
    static public float vi; //体力の数値
    static public float lu; //運の数値
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

    static public int test;//小学校試験　仮の変数

    /// <summary>
    /// はじめから開始時にすべての変数をリセットするメソッド
    /// </summary>
    static public void initStatus ()
    {
        mf = 0;  //入力なしの場合は男性になる
        clanName = "佐々木";   //入力なしの場合は佐々木になる
        co = 0;
        ec = 0;
        ac = 0;
        hu = 0;
        vi = 0;
        lu = 0;
        geneNumber = 0;         //世代数
        //license[0] = "無資格"; //初めの資格が無資格ならその後の資格は探索されないようにしてください。
        lifeTime = 1800f;      //仮代入、一番初めに使う値をいれる
        progress = 0;
        job = "無職";         //暫定無職、小学生とかいれてもいいかも？
        marriage = 0;    //生まれながら結婚している奴などいない！
        children = 1;        //残機的な扱いのつもり（０でゲームオーバー的な）
        schoolFlag = 0;      //0=無所属
        clubFlag = 2;       //初期は無所属なので２
        courseYear = 1;      //経過年数なので初期値は１年目
    }

    /// <summary>
    /// 値を確認したいとき等に使う。基本未使用
    /// </summary>
    public void DebugButton()
    {//デバッグ用ボタン用
        Debug.Log("ClanName is…" + clanName);
        Debug.Log("mf is…" + mf);
    }

    /// <summary>
    /// Jokerのシーンから変数を受け取る
    /// </summary>
    static public void GetConverter()
    {
        mf = int.Parse(StatusManager.variable.get("f.mf"));
        clanName = StatusManager.variable.get("f.clanName");
        co = float.Parse(StatusManager.variable.get("f.co"));
        ec = float.Parse(StatusManager.variable.get("f.ec"));
        ac = float.Parse(StatusManager.variable.get("f.ac"));
        hu = float.Parse(StatusManager.variable.get("f.hu"));
        vi = float.Parse(StatusManager.variable.get("f.vi"));
        lu = float.Parse(StatusManager.variable.get("f.lu"));
        geneNumber = float.Parse(StatusManager.variable.get("f.geneNumber"));
        lifeTime = float.Parse(StatusManager.variable.get("f.lifeTime"));
        progress = int.Parse(StatusManager.variable.get("f.progress"));
        job = StatusManager.variable.get("f.job");
        marriage = int.Parse(StatusManager.variable.get("f.marriage"));
        children = int.Parse(StatusManager.variable.get("f.children"));
        schoolFlag = int.Parse(StatusManager.variable.get("f.schoolFlag"));
        clubFlag = int.Parse(StatusManager.variable.get("f.clubFlag"));
        courseYear = int.Parse(StatusManager.variable.get("f.couceYear"));

        test = int.Parse(StatusManager.variable.get("f.test"));

    }

    /// <summary>
    /// Jokerのシーンへ変数を受け渡す
    /// </summary>
    static public void InitConverter()
    {        
        StatusManager.variable.set("f.mf", ((int)mf).ToString());
        StatusManager.variable.set("f.clanName", clanName.ToString());
        StatusManager.variable.set("f.co", ((float)co).ToString());
        StatusManager.variable.set("f.ec", ((float)ec).ToString());
        StatusManager.variable.set("f.ac", ((float)ac).ToString());
        StatusManager.variable.set("f.hu", ((float)hu).ToString());
        StatusManager.variable.set("f.vi", ((float)vi).ToString());
        StatusManager.variable.set("f.lu", ((float)lu).ToString());
        StatusManager.variable.set("f.geneNumber", ((float)geneNumber).ToString());
        StatusManager.variable.set("f.lifeTime", ((float)lifeTime).ToString());
        StatusManager.variable.set("f.progress", ((int)progress).ToString());
        StatusManager.variable.set("f.job", job.ToString());
        StatusManager.variable.set("f.marriage", ((int)marriage).ToString());
        StatusManager.variable.set("f.children", ((int)children).ToString());
        StatusManager.variable.set("f.schoolFlag", ((int)schoolFlag).ToString());
        StatusManager.variable.set("f.clubFlag", ((int)clubFlag).ToString());
        StatusManager.variable.set("f.courceYear", ((int)courseYear).ToString());
    }

    /// <summary>
    /// セーブデータ保存
    /// </summary>
    static public void static_Save()
    {
        PlayerPrefs.SetString("clanName", PlayerStatus.clanName);
        PlayerPrefs.SetInt("mf", PlayerStatus.mf);
    }

    /// <summary>
    /// セーブデータ読み込み
    /// </summary>
    static public void static_Load()
    {
        PlayerStatus.clanName = PlayerPrefs.GetString("clanName");
        PlayerStatus.mf = PlayerPrefs.GetInt("mf");
    }
}