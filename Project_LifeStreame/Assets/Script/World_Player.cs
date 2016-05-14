using UnityEngine;
using System.Collections;

public class World_Player : MonoBehaviour {

    public float camera;//カメラ
    public float cameraStop;//カメラ停止


    public float progress;//進行度

    public Transform target_ElementarySchool;

    public Transform target_JuniorHighSchool;

    public Transform target_HighSchool;

    public Transform target_ProfessionalSchool;

    public Transform target_University;

    public Transform target_MemberOfSociety;

    public Transform target_GoldenAger;


    NavMeshAgent agent;

    // Use this for initialization
    void Awake() {
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update() {
        if (progress == 1)
        {
            agent.SetDestination(target_ElementarySchool.position);//小学校までレッツゴー
        }

        if (progress == 2)
        {
            agent.SetDestination(target_JuniorHighSchool.position);//中学校までレッツゴー
        }

        if (progress == 3)
        {
            agent.SetDestination(target_HighSchool.position);//高校までレッツゴー
        }

        if (progress == 4)
        {
            agent.SetDestination(target_ProfessionalSchool.position);//専門学校までレッツゴー
        }

        if (progress == 5)
        {
            agent.SetDestination(target_University.position);//大学までレッツゴー
        }

        if (progress == 6)
        {
            agent.SetDestination(target_MemberOfSociety.position);//社会人までレッツゴー
        }

        if (progress == 7)
        {
            agent.SetDestination(target_GoldenAger.position);//年寄りまでレッツゴー
        }


    }

    

}

