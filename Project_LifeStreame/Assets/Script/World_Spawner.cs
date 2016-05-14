using UnityEngine;
using System.Collections;

public class World_Spawner : MonoBehaviour {

    public GameObject Player;
    public float progress;//進行度

    public Transform spawner_ElementarySchool;//小学校

    public Transform spawner_JuniorHighSchool;//中学校

    public Transform spawner_HighSchool;//高校

    public Transform spawner_ProfessionalSchool;//専門学校

    public Transform spawner_University;//大学

    public Transform spawner_MemberOfSociety;//社会人

    public Transform spawner_GoldenAger;//年寄り

    // Use this for initialization
    void Awake () {
        if (progress == 1)
        {
            Instantiate(Player, spawner_ElementarySchool.position, spawner_ElementarySchool.rotation);//小学校前にスポーン
        }

        if (progress == 2)
        {
            Instantiate(Player, spawner_JuniorHighSchool.position, spawner_JuniorHighSchool.rotation);//中学校前にスポーン
        }

        if (progress == 3)
        {
            Instantiate(Player, spawner_HighSchool.position, spawner_HighSchool.rotation);//高校前にスポーン
        }

        if (progress == 4)
        {
            Instantiate(Player, spawner_ProfessionalSchool.position, spawner_ProfessionalSchool.rotation);//専門学校前にスポーン
        }

        if (progress == 5)
        {
            Instantiate(Player, spawner_University.position, spawner_University.rotation);//大学前にスポーン
        }

        if (progress == 6)
        {
            Instantiate(Player, spawner_MemberOfSociety.position, spawner_MemberOfSociety.rotation);//社会人前にスポーン
        }

        if (progress == 7)
        {
            Instantiate(Player, spawner_GoldenAger.position, spawner_GoldenAger.rotation);//年寄り前にスポーン
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
