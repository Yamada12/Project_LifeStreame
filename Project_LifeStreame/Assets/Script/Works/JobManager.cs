﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Novel;

public class JobManager : MonoBehaviour
{
    public Text jobName;            //職業の名前
    public Text acPoints;           //給料（経済力）
    public Text necessaryAbilty;    //必須能力値
    public Text test;               //試験は何をするか
    public Text detail;             //職業の詳細
    public GameObject[] jobList;    //ジョブボタンズ

    public GameObject movePoints;
    public GameObject basePoint;
    public GameObject sendPoint;
    private Vector3 basePoints_Origin;

    public GameObject applicationButton;
    public GameObject turningPanel;

    void Start ()
    {
        SoundPlayer.Instance.PlayBGM("Work");
        basePoints_Origin = basePoint.gameObject.transform.position;
        jobName.text = "職業名";
        acPoints.text = "数値/仕事一回辺り";
        necessaryAbilty.text = "必須能力値が表示されます。";
        test.text = "試験の内容が表示されます。";
        detail.text = "ここに各職業毎の詳細が記載されます。";
        jobChecker();
	}

    public void AnimJobVote(bool In)
    {//応募時のアニメーションとキャンセル時のアニメーション
        if (In)
        {
            applicationButton.SetActive(false);
            turningPanel.SetActive(true);
            basePoint.transform.localRotation = Quaternion.Euler(0, 180, 0);
            iTween.ScaleTo(basePoint, iTween.Hash("x", 1.25f, "y", 1.25f, "time", 1f));
            iTween.RotateTo(basePoint, iTween.Hash("y", 360, "time", 1f));
            iTween.MoveTo(basePoint, iTween.Hash("position", movePoints.gameObject.transform.position, "time", 1f));
        }
        else {
            applicationButton.SetActive(true);
            turningPanel.SetActive(false);
            iTween.ScaleTo(basePoint, iTween.Hash("x", 1f, "y", 1f, "time", 0.5f));
            iTween.MoveTo(basePoint, iTween.Hash("position", basePoints_Origin, "time", 0.5f));
        }
    }

    public void SendAnimation()
    {
        turningPanel.SetActive(false);
        iTween.MoveTo(basePoint, iTween.Hash("position", sendPoint.gameObject.transform.position, "time", 1f, "oncomplete", "LastBattle", "oncompletetarget", this.gameObject));
    }

    void LastBattle()
    {
        PlayerStatus.InitConverter();
        PlayerStatus.progress = 7;
        NovelSingleton.StatusManager.callJoker("wide/Syogaku/mensetu", "");
        //SceneManager.LoadScene("World", LoadSceneMode.Single);

    }

    public void JobsVote(int jobID)
    {
        switch (jobID)
        {
            case 0://フリーター
                jobName.text = "フリーター";
                acPoints.text = "10経済力/1works";
                necessaryAbilty.text = "特になし";
                test.text = "面接";
                detail.text = "バイト戦士\n決まった職に就かずにその場しのぎで生きていく。\n何の理由であれ職業に就くことは大事だと痛感してしまう。";
                PlayerStatus.job = "フリーター";
                break;
            case 1://サラリーマン
                jobName.text = "サラリーマン";
                acPoints.text = "12経済力/1works";
                necessaryAbilty.text = "基礎的な能力があればだれでも";
                test.text = "面接";
                detail.text = "正社員。\n何の変哲もないただの会社員。\n日々体を張って家族を養う一家のスーパーヒーロー。";
                PlayerStatus.job = "サラリーマン";
                break;
            case 2://料理人
                jobName.text = "料理人";
                acPoints.text = "15経済力/1works";
                necessaryAbilty.text = "お客様への対応力と修行に耐える体力";
                test.text = "実技試験";
                detail.text = "料亭の調理担当。\n調理に関する様々な知識を学ぶことが出来る。";
                PlayerStatus.job = "料理人";
                break;
            case 3://医者
                jobName.text = "医者";
                acPoints.text = "30経済力/1works";
                necessaryAbilty.text = "医学に対する知識と高い人間性";
                test.text = "筆記試験";
                detail.text = "人の命を扱う大事な仕事。\n医療に対する深い知識と\n患者に対する真摯な対応力が重要な仕事";
                PlayerStatus.job = "医者";
                break;
            case 4://芸能人
                jobName.text = "芸能人";
                acPoints.text = "15経済力/1works";
                necessaryAbilty.text = "人を楽しませるコミュ力とヒットする運が必要";
                test.text = "実技試験";
                detail.text = "人を楽しませるエンターテイナーのエキスパート。\n他人を楽しませるにはまず自分が楽しまなければ！\n時には運だって必要なんです。";
                PlayerStatus.job = "芸能人";
                break;
            case 5://警察
                jobName.text = "警察";
                acPoints.text = "24経済力/1works";
                necessaryAbilty.text = "犯罪者にも平等に接する寛容な人間力が必要";
                test.text = "実技試験";
                detail.text = "現代の正義の味方。\n日本の治安は彼らによって守られている。\n犯罪者を許さない正義の心と受け入れる寛容さが重要。\n勿論、体力も";
                PlayerStatus.job = "警察";
                break;
            case 6://教師
                jobName.text = "教師";
                acPoints.text = "23経済力/1works";
                necessaryAbilty.text = "生徒との信頼関係を築くコミュ力と模範となる人間力が必要";
                test.text = "筆記試験、面接";
                detail.text = "子供へ夢と希望を与える大事な仕事。\n常に模範とならなければいけないので結構神経を使う。\nどんな生徒でも平等に接する人間力が求められる。";
                PlayerStatus.job = "教師";
                break;
            case 7://消防士
                jobName.text = "消防士";
                acPoints.text = "25経済力/1works";
                necessaryAbilty.text = "命を重んじる人間力と強靭な体力が必要";
                test.text = "実技試験";
                detail.text = "人命救助のエキスパート。\n炎に向かう勇気と生きて帰る運が必要。";
                PlayerStatus.job = "消防士";
                break;
            case 8://自衛隊
                jobName.text = "自衛隊";
                acPoints.text = "18経済力/1works";
                necessaryAbilty.text = "訓練に耐える体力と寛容な人間力が必要";
                test.text = "実技試験";
                detail.text = "国を守る大事な仕事。\n災害時に迅速な対応が求められる。";
                PlayerStatus.job = "自衛隊";
                break;
            case 9://スポーツ選手
                jobName.text = "スポーツ選手";
                acPoints.text = "100経済力/1works";
                necessaryAbilty.text = "体力と道具代を賄える経済力が必要";
                test.text = "実技試験";
                detail.text = "みんなの憧れスポーツ選手。\n何のスポーツかって？それは内緒だ。";
                PlayerStatus.job = "スポーツ選手";
                break;
            case 10://美容師
                jobName.text = "美容師";
                acPoints.text = "18経済力/1works";
                necessaryAbilty.text = "お客さんの対応をそつなくこなせる能力が必要";
                test.text = "面接";
                detail.text = "意外とお世話になる機会の多い職業。\n常連さんを作るためにはまずコミュニケーションから！";
                PlayerStatus.job = "美容師";
                break;
            case 11://システムエンジニア
                jobName.text = "システムエンジニア";
                acPoints.text = "21経済力/1works";
                necessaryAbilty.text = "プログラミング能力(学力)";
                test.text = "面接";
                detail.text = "陰で社会を支える縁の下の力持ち。\n表に出ない仕事だが、なくてはならない大事な職業。";
                PlayerStatus.job = "システムエンジニア";
                break;
            case 12://音楽家
                jobName.text = "音楽家";
                acPoints.text = "17経済力/1works";
                necessaryAbilty.text = "音を人に届ける表現力と楽器を揃える経済力が必要";
                test.text = "面接";
                detail.text = "演奏で何かを伝える為にはどうするか？\nまずコミュニケーションとは何かを知らなければならない。";
                PlayerStatus.job = "音楽家";
                break;
            case 13://農家
                jobName.text = "農家";
                acPoints.text = "16経済力/1works";
                necessaryAbilty.text = "野菜を根気よく育てる体力と災害に合わない運が必要";
                test.text = "特になし";
                detail.text = "野菜農家。\n野菜を育てて生活するのはそれなりの覚悟が必要。\nしかし災害には勝てない…";
                PlayerStatus.job = "農家";
                break;
            case 14://小説家
                jobName.text = "小説家";
                acPoints.text = "15経済力/1works";
                necessaryAbilty.text = "多彩な用語を習得する学力と表現の仕方に人間性が関わってくる";
                test.text = "特になし";
                detail.text = "夢を追いかける冒険家。\n文字で世界を作るいわば神様。\n一歩間違えば自意識に拘束されてしまう。";
                PlayerStatus.job = "小説家";
                break;
            case 15://科学者
                jobName.text = "科学者";
                acPoints.text = "32経済力/1works";
                necessaryAbilty.text = "科学を追及する学力と日々謎を探求していく人間性が必要";
                test.text = "筆記試験、実技試験";
                detail.text = "現代の魔法使い。\n今までにない物を作り出すクリエイター。\n難しい問題に挑戦していく強靭なメンタルが必要";
                PlayerStatus.job = "科学者";
                break;
            case 16://運送業
                jobName.text = "運送業";
                acPoints.text = "22経済力/1works";
                necessaryAbilty.text = "物資を丁寧に届ける人間性と夜の運転に耐えられる体力が必要。";
                test.text = "面接";
                detail.text = "トラックの運転手。\n夜間に長距離移動をしなければならない為、結構ハード。\nいち早く荷物を届ける一心で今日も夜道を走る。";
                PlayerStatus.job = "運送業";
                break;
            case 17://土木業
                jobName.text = "土木業";
                acPoints.text = "16経済力/1works";
                necessaryAbilty.text = "一日中動ける体力とチーム連携が出来るコミュ力";
                test.text = "面接";
                detail.text = "住を支える仕事。\n一歩間違えば大きな怪我に繋がる現場では、チームでの連携が必須になる。\n体を張る仕事なので体力も勿論必須。";
                PlayerStatus.job = "土木業";
                break;
            case 18://デザイナー
                jobName.text = "デザイナー";
                acPoints.text = "19経済力/1works";
                necessaryAbilty.text = "デザインを話し合えるコミュ力";
                test.text = "実技試験、面接";
                detail.text = "人々の目に触れる機会の多いデザインを制作する仕事。\n絵はセンスと練習でどうにでもなる！らしい。\n依頼されたデザインを的確に絵に起こせるコミュ力が大事。";
                PlayerStatus.job = "デザイナー";
                break;
            case 19://歌手
                jobName.text = "歌手";
                acPoints.text = "20経済力/1works";
                necessaryAbilty.text = "ライブを歌い続ける体力とファンに笑顔で接するコミュ力が必要";
                test.text = "実技試験、面接";
                detail.text = "人々に笑顔と感動を届けるエンターテイナー。\n簡単なようで陰で努力を惜しまない頑張り屋。\n今日も大勢のファンのためにステージに立つ。";
                PlayerStatus.job = "歌手";
                break;
            case 20://カメラマン
                jobName.text = "カメラマン";
                acPoints.text = "15経済力/1works";
                necessaryAbilty.text = "移動費を賄える経済力と決定的瞬間に巡り合える運が必要。";
                test.text = "特になし";
                detail.text = "シャッターチャンスを逃さない現代のスナイパー。\nありきたりな写真では生計を立てられないので貴重な一瞬を見逃せない。\nパパラッチは敵。";
                PlayerStatus.job = "カメラマン";
                break;
            case 21://宇宙飛行士
                jobName.text = "宇宙飛行士";
                acPoints.text = "42経済力/1works";
                necessaryAbilty.text = "人並み以上の能力と宇宙での活動にも耐えられる体力。";
                test.text = "筆記試験、面接、実技試験";
                detail.text = "宇宙を目指すロマン溢れる仕事。\n人一倍の努力と人一倍の宇宙への憧れが必要。\nIt's a piece of cake!";
                PlayerStatus.job = "宇宙飛行士";
                break;
            case 22://漁師
                jobName.text = "漁師";
                acPoints.text = "20経済力/1works";
                necessaryAbilty.text = "魚を引き揚げる体力と船を動かす経済力が必要";
                test.text = "特になし";
                detail.text = "上手くいくかは海次第。\n釣れなければ手段を変える。\n漁師に必要な条件はただ一つ、頭より先に手を動かせ！";
                PlayerStatus.job = "漁師";
                break;
            case 23://ダンサー
                jobName.text = "ダンサー";
                acPoints.text = "17経済力/1works";
                necessaryAbilty.text = "踊り続ける体力と人前で踊れるコミュ力が必要";
                test.text = "実技試験";
                detail.text = "ダンサーに恥じらいはご法度。\n内に眠る情熱を全身を使って表現しよう。\nダンサーに必要なのは踊る事のみ。";
                PlayerStatus.job = "ダンサー";
                break;
            case 24://弁護士
                jobName.text = "弁護士";
                acPoints.text = "30経済力/1works";
                necessaryAbilty.text = "法律を学ぶ学力と容疑者を救うべく努力する人間性";
                test.text = "筆記試験、面接";
                detail.text = "どんな犯罪者であろうと潔白を証明する最後の砦。\n隠された真実を追求していく\n「異議なし！！」";
                PlayerStatus.job = "弁護士";
                break;
            case 25://†占い師†
                jobName.text = "占い師";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "天のお導きのままに…";
                test.text = "特になし";
                detail.text = "生まれつきの霊感など必要ない。\n占い師の最大の難関は結果を人にうまく伝える事である。";
                PlayerStatus.job = "占い師";
                break;
            case 26://†執事・メイド†
                jobName.text = "執事・メイド";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "ご主人に気に入られる事";
                test.text = "面接";
                detail.text = "屋敷の主人の使用人。\n家事全般から身の回りの世話までなんでもこなすすごい人。\n運と経済力以外の要素が必要。";
                PlayerStatus.job = "執事・メイド";
                break;
            case 27://†正義の味方†
                jobName.text = "正義の味方";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "愛と勇気";
                test.text = "特になし";
                detail.text = "アニメでみた正義の味方にあこがれて、将来は正義の味方になると誓った。\nあれから血のにじむような努力を重ねてきた。しかし…\n「またツーパンで終わってしまった…」";
                PlayerStatus.job = "正義の味方";
                break;
            case 28://†スタントマン†
                jobName.text = "スタントマン";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "デンジャラスな人";
                test.text = "特になし";
                detail.text = "スタントは命がけ！\n誰もやりたがらない危険なスタントからこそ興奮が生まれる。\nやるかやらないかは自分次第。";
                PlayerStatus.job = "スタントマン";
                break;
            case 29://†配管工†
                jobName.text = "配管工";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "キノコに対する深い知識";
                test.text = "筆記試験";
                detail.text = "桃プリンセスが攫われたら助けに行くお仕事。\nレンガを破壊する力と毒キノコを見極めるサバイバル知識が必要。\n配管工事はどうしたって？そんなもんただの肩書だよ！";
                PlayerStatus.job = "配管工";
                break;
            case 30://†ギャンブラー†
                jobName.text = "ギャンブラー";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "ポーカーフェイス";
                test.text = "特になし";
                detail.text = "自分には何もないって？\nいやいやそんなことはない。能力なんて関係ないんだよ。\nそうなぜなら、運があるから。";
                PlayerStatus.job = "ギャンブラー";
                break;
            case 31://‡王子・王女‡
                jobName.text = "王子・王女";
                acPoints.text = "??経済力/1works";
                necessaryAbilty.text = "聖人の如きコミュ力と莫大な遺産と博士級の学力と\n仏級の人間性と世界の確率が視認できる程の運と\n無限大の体力";
                test.text = "国家認定";
                detail.text = "世界を統べる王の養子。\nすべての人類の頂点に立てる能力が必要。\n彼らの発言が世界の情勢を変える。";
                PlayerStatus.job = "王子・王女";
                break;
            default:
                jobName.text = "求人票";
                acPoints.text = "00経済力/1works";
                necessaryAbilty.text = "必須能力";
                test.text = "試験内容";
                detail.text = "ここに各職業毎の詳細が記載されます。";
                PlayerStatus.job = "フリーター";
                break;
        }
        PlayerStatus.static_Save();
    }

    /// <summary>
    /// 就職可能なジョブかどうか
    /// </summary>
    void jobChecker()
    {
        for(int i = 0; i < jobList.Length; i++)
        {//一度すべてのジョブをFalseにする
            jobList[i].GetComponent<Button>().interactable = false;
        }

        //フリーターは常時オン
        jobList[0].GetComponent<Button>().interactable = true;

        //サラリーマン
        if (PlayerStatus.ac >= 100 && PlayerStatus.vi >= 100)
            jobList[1].GetComponent<Button>().interactable = true;

        //料理人
        if (PlayerStatus.ac >= 200 && PlayerStatus.co >= 100)
            jobList[2].GetComponent<Button>().interactable = true;

        //医者
        if (PlayerStatus.ac >= 200 && PlayerStatus.hu >= 200)
            jobList[3].GetComponent<Button>().interactable = true;

        //芸能人
        if (PlayerStatus.co >= 100 && PlayerStatus.lu >= 100)
            jobList[4].GetComponent<Button>().interactable = true;

        //警察
        if (PlayerStatus.hu >= 200 && PlayerStatus.vi >= 100)
            jobList[5].GetComponent<Button>().interactable = true;

        //教師
        if (PlayerStatus.ac >= 200 && PlayerStatus.hu >= 200)
            jobList[6].GetComponent<Button>().interactable = true;

        //消防士
        if (PlayerStatus.vi >= 200 && PlayerStatus.lu >= 100)
            jobList[7].GetComponent<Button>().interactable = true;

        //自衛隊
        if (PlayerStatus.vi >= 300 && PlayerStatus.lu >= 100)
            jobList[8].GetComponent<Button>().interactable = true;

        //スポーツ選手
        if (PlayerStatus.vi >= 300 && PlayerStatus.ac >= 100)
            jobList[9].GetComponent<Button>().interactable = true;

        //美容師
        if (PlayerStatus.hu >= 100 && PlayerStatus.co >= 200)
            jobList[10].GetComponent<Button>().interactable = true;

        //システムエンジニア
        if (PlayerStatus.ac >= 300 && PlayerStatus.co >= 100)
            jobList[11].GetComponent<Button>().interactable = true;

        //音楽家
        if (PlayerStatus.ec >= 300 && PlayerStatus.vi >= 200)
            jobList[12].GetComponent<Button>().interactable = true;

        //農家
        if (PlayerStatus.vi >= 300)
            jobList[13].GetComponent<Button>().interactable = true;

        //小説家
        if (PlayerStatus.ac >= 200 && PlayerStatus.vi >= 200)
            jobList[14].GetComponent<Button>().interactable = true;

        //科学者
        if (PlayerStatus.ac >= 300 && PlayerStatus.hu >= 200)
            jobList[15].GetComponent<Button>().interactable = true;

        //運送業
        if (PlayerStatus.vi >= 300)
            jobList[16].GetComponent<Button>().interactable = true;

        //土木業
        if (PlayerStatus.co >= 100 && PlayerStatus.vi >= 300)
            jobList[17].GetComponent<Button>().interactable = true;

        //デザイナー
        if (PlayerStatus.ac >= 100 && PlayerStatus.co >= 200)
            jobList[18].GetComponent<Button>().interactable = true;

        //歌手
        if (PlayerStatus.vi >= 300 && PlayerStatus.co >= 200)
            jobList[19].GetComponent<Button>().interactable = true;

        //カメラマン
        if (PlayerStatus.ec >= 200 && PlayerStatus.vi >= 200)
            jobList[20].GetComponent<Button>().interactable = true;

        //宇宙飛行士
        if (PlayerStatus.vi >= 300 && PlayerStatus.lu >= 200)
            jobList[21].GetComponent<Button>().interactable = true;

        //漁師
        if (PlayerStatus.vi >= 200 && PlayerStatus.lu >= 100)
            jobList[22].GetComponent<Button>().interactable = true;

        //ダンサー
        if (PlayerStatus.vi >= 200 && PlayerStatus.co >= 100)
            jobList[23].GetComponent<Button>().interactable = true;

        //弁護士
        if (PlayerStatus.ac >= 400 && PlayerStatus.hu >= 200)
            jobList[24].GetComponent<Button>().interactable = true;

        //占い師
        if (PlayerStatus.ac >= 400)
            jobList[25].GetComponent<Button>().interactable = true;

        //執事・メイド
        if (PlayerStatus.ac >= 300 && PlayerStatus.hu >= 300 && PlayerStatus.co >= 300 && PlayerStatus.vi >= 300)
            jobList[26].GetComponent<Button>().interactable = true;

        //正義のヒーロー
        if (PlayerStatus.vi >= 500 && PlayerStatus.lu >= 100)
            jobList[27].GetComponent<Button>().interactable = true;

        //スタントマン
        if (PlayerStatus.vi >= 200 && PlayerStatus.lu >= 300)
            jobList[28].GetComponent<Button>().interactable = true;

        //配管工
        if (PlayerStatus.ac >= 100 && PlayerStatus.ec >= 100 && PlayerStatus.hu >= 100 && PlayerStatus.co >= 100 && PlayerStatus.vi >= 100)
            jobList[29].GetComponent<Button>().interactable = true;

        //ギャンブラー
        if (PlayerStatus.lu >= 400)
            jobList[30].GetComponent<Button>().interactable = true;

        //配管工
        if (PlayerStatus.ac >= 700 && PlayerStatus.ec >= 700 && PlayerStatus.hu >= 700 && PlayerStatus.co >= 500 && PlayerStatus.lu >= 300)
            jobList[31].GetComponent<Button>().interactable = true;
    }
}
