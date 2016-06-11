﻿using UnityEngine;
using System.Collections;
using Novel;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// ユーザーの情報を管理するスクリプト
/// </summary>
public class PlayerStatus : MonoBehaviour
{
    static public int mf = 1;                  //性別　0＝男性　1=女性
    static public string clanName = "みやの";   //一族の名前
    static public float co = 0;                    //コミュ力の数値   最大値999
    static public float ec = 0;                     //経済力の数値
    static public float ac = 0;                     //学力の数値
    static public float hu = 0;                     //人間力の数値
    static public float vi = 0;                     //体力の数値
    static public float lu = 0;                     //運の数値
    static public float geneNumber = 1;             //世代数
    static public float lifeTime = 1200f;               //残り時間
    static public int progress = 1;                 //進行度   小学校＝１　2年生＝２　etc...
    static public string job = "小学生";        //ジョブ名（職業名）
    static public int marriage;                //結婚しているかどうか？　0＝結婚している　1=結婚してない
    static public int children;                 //子供の人数（双子かどうか？）
    static public int schoolFlag;               //所属学校（０なら無所属、１なら？？学校　etc...）
    static public int clubFlag;                 //部活動は何系か？　0＝文化　1＝運動　2=無所属
    static public int courseYear;               //経過年数（現在の進行度に何年滞在したか？※学年など）
    static public int lp_tun;                   //好感度：ツンデレ
    static public int lp_maji;                  //好感度：真面目
    static public int lp_supo;                  //好感度：スポコン
    static public int lp_hika;                  //好感度：控え目
    static public int lp_ten;                   //好感度：天然
    static public int lp_mega;                  //好感度：インテリメガネ
    static public int lp_kama;                  //好感度：カマセ
    static public int lp_nago;                  //好感度：和やか
    static public int lp_ore;                   //好感度：オレサマ
    static public int lp_ani;                   //好感度：アニキ

    /// <summary>
    /// はじめから開始時にすべての変数をリセットするメソッド
    /// </summary>
    static public void initStatus ()
    {
        mf = 0;  //入力なしの場合は男性になる
        clanName = "みやの";   //入力なしの場合はみやのになる
        co = 0;
        ec = 0;
        ac = 0;
        hu = 0;
        vi = 0;
        lu = 0;
        geneNumber = 1;         //世代数
        lifeTime = 1200f;      //仮代入、一番初めに使う値をいれる
        progress = 1;
        job = "無職";         //暫定無職、小学生とかいれてもいいかも？
        marriage = 0;    //生まれながら結婚している奴などいない！
        children = 1;        //残機的な扱いのつもり（０でゲームオーバー的な）
        schoolFlag = 0;      //0=無所属
        clubFlag = 2;       //初期は無所属なので２
        courseYear = 1;      //経過年数なので初期値は１年目
        lp_tun = 0;
        lp_maji = 0;
        lp_supo = 0;
        lp_hika = 0;
        lp_ten = 0;
        lp_mega = 0;
        lp_kama = 0;
        lp_nago = 0;
        lp_ore = 0;
        lp_ani = 0;
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
    /// 使ってないぽい？
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
        StatusManager.variable.set("f.sceneName", (SceneManager.GetActiveScene().name));
        StatusManager.variable.set("f.lp_tun", ((int)lp_tun).ToString());
        StatusManager.variable.set("f.lp_maji", ((int)lp_maji).ToString());
        StatusManager.variable.set("f.lp_supo", ((int)lp_supo).ToString());
        StatusManager.variable.set("f.lp_hika", ((int)lp_hika).ToString());
        StatusManager.variable.set("f.lp_ten", ((int)lp_ten).ToString());
        StatusManager.variable.set("f.lp_mega", ((int)lp_mega).ToString());
        StatusManager.variable.set("f.lp_kama", ((int)lp_kama).ToString());
        StatusManager.variable.set("f.lp_nago", ((int)lp_nago).ToString());
        StatusManager.variable.set("f.lp_ore", ((int)lp_ore).ToString());
        StatusManager.variable.set("f.lp_ani", ((int)lp_ani).ToString());
    }

    /// <summary>
    /// セーブデータ保存
    /// </summary>
    static public void static_Save()
    {
        PlayerPrefs.SetString("clanName", PlayerStatus.clanName);
        PlayerPrefs.SetInt("mf", PlayerStatus.mf);
        PlayerPrefs.SetFloat("co", PlayerStatus.co);
        PlayerPrefs.SetFloat("ec", PlayerStatus.ec);
        PlayerPrefs.SetFloat("ac", PlayerStatus.ac);
        PlayerPrefs.SetFloat("hu", PlayerStatus.hu);
        PlayerPrefs.SetFloat("vi", PlayerStatus.vi);
        PlayerPrefs.SetFloat("lu", PlayerStatus.lu);
        PlayerPrefs.SetFloat("geneNumber", PlayerStatus.geneNumber);
        PlayerPrefs.SetFloat("lifeTime", PlayerStatus.lifeTime);
        PlayerPrefs.SetInt("progress", PlayerStatus.progress);
        PlayerPrefs.SetString("job", PlayerStatus.job);
        PlayerPrefs.SetInt("marriage", PlayerStatus.marriage);
        PlayerPrefs.SetInt("children", PlayerStatus.children);
        PlayerPrefs.SetInt("schoolFlag", PlayerStatus.schoolFlag);
        PlayerPrefs.SetInt("clubFlag", PlayerStatus.clubFlag);
        PlayerPrefs.SetInt("courceYear", PlayerStatus.courseYear);
        PlayerPrefs.SetInt("lp_tun", PlayerStatus.lp_tun);
        PlayerPrefs.SetInt("lp_maji", PlayerStatus.lp_maji);
        PlayerPrefs.SetInt("lp_supo", PlayerStatus.lp_supo);
        PlayerPrefs.SetInt("lp_hika", PlayerStatus.lp_hika);
        PlayerPrefs.SetInt("lp_ten", PlayerStatus.lp_ten);
        PlayerPrefs.SetInt("lp_mega", PlayerStatus.lp_mega);
        PlayerPrefs.SetInt("lp_kama", PlayerStatus.lp_kama);
        PlayerPrefs.SetInt("lp_nago", PlayerStatus.lp_nago);
        PlayerPrefs.SetInt("lp_ore", PlayerStatus.lp_ore);
        PlayerPrefs.SetInt("lp_ani", PlayerStatus.lp_ani);
    }

    /// <summary>
    /// セーブデータ読み込み
    /// </summary>
    static public void static_Load()
    {
        PlayerStatus.clanName = PlayerPrefs.GetString("clanName");
        PlayerStatus.mf = PlayerPrefs.GetInt("mf");
        PlayerStatus.co = PlayerPrefs.GetFloat("co");
        PlayerStatus.ec = PlayerPrefs.GetFloat("ec");
        PlayerStatus.ac = PlayerPrefs.GetFloat("ac");
        PlayerStatus.hu = PlayerPrefs.GetFloat("hu");
        PlayerStatus.vi = PlayerPrefs.GetFloat("vi");
        PlayerStatus.lu = PlayerPrefs.GetFloat("lu");
        PlayerStatus.geneNumber = PlayerPrefs.GetFloat("geneNumber");
        PlayerStatus.lifeTime = PlayerPrefs.GetFloat("lifeTime");
        PlayerStatus.progress = PlayerPrefs.GetInt("progress");
        PlayerStatus.job = PlayerPrefs.GetString("job");
        PlayerStatus.marriage = PlayerPrefs.GetInt("marriage");
        PlayerStatus.children = PlayerPrefs.GetInt("children");
        PlayerStatus.schoolFlag = PlayerPrefs.GetInt("schoolFlag");
        PlayerStatus.clubFlag = PlayerPrefs.GetInt("clubFlag");
        PlayerStatus.courseYear = PlayerPrefs.GetInt("courceYear");
        PlayerStatus.lp_tun = PlayerPrefs.GetInt("lp_tun");
        PlayerStatus.lp_maji = PlayerPrefs.GetInt("lp_maji");
        PlayerStatus.lp_supo = PlayerPrefs.GetInt("lp_supo");
        PlayerStatus.lp_hika = PlayerPrefs.GetInt("lp_hika");
        PlayerStatus.lp_ten = PlayerPrefs.GetInt("lp_ten");
        PlayerStatus.lp_mega = PlayerPrefs.GetInt("lp_mega");
        PlayerStatus.lp_kama = PlayerPrefs.GetInt("lp_kama");
        PlayerStatus.lp_nago = PlayerPrefs.GetInt("lp_nago");
        PlayerStatus.lp_ore = PlayerPrefs.GetInt("lp_ore");
        PlayerStatus.lp_ani = PlayerPrefs.GetInt("lp_ani");
    }
}