using UnityEngine;
using System.Collections;

    [RequireComponent(typeof(MeshRenderer))]
    [RequireComponent(typeof(MeshFilter))]

public class StatusRenderer : MonoBehaviour
{
    [SerializeField]
    private Material _mat;

    public Vector3 vert1;   //一番上の頂点
    public Vector3 vert2;   //右上の頂点
    public Vector3 vert3;   //右下の頂点
    public Vector3 vert4;   //一番下の頂点
    public Vector3 vert5;   //左下の頂点
    public Vector3 vert6;   //左上の頂点
    private Mesh mesh;

    static public float vert1_step = 0.1f;
    static public float vert2_step = 0.1f;
    static public float vert3_step = 0.1f;
    static public float vert4_step = 0.1f;
    static public float vert5_step = 0.1f;
    static public float vert6_step = 0.1f;

    void Start()
    {
        DefaultVerts();
        UpdateMesh();
    }

    void Update()
    {
        VertCheck();
        UpdateMesh();
    }

    /// <summary>
    /// グラフ初期化
    /// </summary>
    static public void initVerts()
    {
        vert1_step = 0.1f;
        vert2_step = 0.1f;
        vert3_step = 0.1f;
        vert4_step = 0.1f;
        vert5_step = 0.1f;
        vert6_step = 0.1f;
    }

    public void UpdateMesh()
    {//メッシュの形を更新する
        mesh = new Mesh();
        mesh.vertices = new Vector3[]
        {
            vert1 * vert1_step,
            vert2 * vert2_step,
            vert3 * vert3_step,
            vert4 * vert4_step,
            vert5 * vert5_step,
            vert6 * vert6_step,
            new Vector3 (0, 0),     //原点
        };

        mesh.triangles = new int[]
        {//6枚の三角形を組み合わせてレーダーを作る（６は原点）
            0, 1, 6,
            1, 2, 6,
            2, 3, 6,
            3, 4, 6,
            4, 5, 6,
            5, 0, 6
        };

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();

        MeshFilter filter = GetComponent<MeshFilter>();
        filter.sharedMesh = mesh;

        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = _mat;
    }

    public void DefaultVerts()
    {//正六角形に戻す
        vert1 = new Vector3(0, 1.2f);
        vert2 = new Vector3(1f, 0.5f);
        vert3 = new Vector3(1f, -0.5f);
        vert4 = new Vector3(0, -1.2f);
        vert5 = new Vector3(-1f, -0.5f);
        vert6 = new Vector3(-1f, 0.5f);
    }

    void VertCheck()
    {//頂点の位置チェック
        //コミュ力のレーダー位置
        if (PlayerStatus.co >= 125 && PlayerStatus.co < 250)
            vert1_step = 0.5f;
        else if (PlayerStatus.co >= 250 && PlayerStatus.co < 375)
            vert1_step = 1f;
        else if (PlayerStatus.co >= 375 && PlayerStatus.co < 500)
            vert1_step = 1.5f;
        else if (PlayerStatus.co >= 500 && PlayerStatus.co < 625)
            vert1_step = 2f;
        else if (PlayerStatus.co >= 625 && PlayerStatus.co < 750)
            vert1_step = 2.5f;
        else if (PlayerStatus.co >= 750 && PlayerStatus.co < 875)
            vert1_step = 3f;
        else if (PlayerStatus.co >= 875 && PlayerStatus.co < 999)
            vert1_step = 3.5f;
        else if (PlayerStatus.co >= 999)
        {
            vert1_step = 4f;
            PopTrophy.GetTrophy("コミュトロフィー", "コミュ力カンスト", 0);
        }

        //経済力のレーダー位置
        if (PlayerStatus.ec >= 125 && PlayerStatus.ec < 250)
            vert2_step = 0.5f;
        else if (PlayerStatus.ec >= 250 && PlayerStatus.ec < 375)
            vert2_step = 1f;
        else if (PlayerStatus.ec >= 375 && PlayerStatus.ec < 500)
            vert2_step = 1.5f;
        else if (PlayerStatus.ec >= 500 && PlayerStatus.ec < 625)
            vert2_step = 2f;
        else if (PlayerStatus.ec >= 625 && PlayerStatus.ec < 750)
            vert2_step = 2.5f;
        else if (PlayerStatus.ec >= 750 && PlayerStatus.ec < 875)
            vert2_step = 3f;
        else if (PlayerStatus.ec >= 875 && PlayerStatus.ec < 999)
            vert2_step = 3.5f;
        else if (PlayerStatus.ec >= 999)
        {
            vert2_step = 4f;
            PopTrophy.GetTrophy("経済トロフィー", "経済力カンスト", 1);
        }

        //学力のレーダー位置
        if (PlayerStatus.ac >= 125 && PlayerStatus.ac < 250)
            vert3_step = 0.5f;
        else if (PlayerStatus.ac >= 250 && PlayerStatus.ac < 375)
            vert3_step = 1f;
        else if (PlayerStatus.ac >= 375 && PlayerStatus.ac < 500)
            vert3_step = 1.5f;
        else if (PlayerStatus.ac >= 500 && PlayerStatus.ac < 625)
            vert3_step = 2f;
        else if (PlayerStatus.ac >= 625 && PlayerStatus.ac < 750)
            vert3_step = 2.5f;
        else if (PlayerStatus.ac >= 750 && PlayerStatus.ac < 875)
            vert3_step = 3f;
        else if (PlayerStatus.ac >= 875 && PlayerStatus.ac < 999)
            vert3_step = 3.5f;
        else if (PlayerStatus.ac >= 999)
        {
            vert3_step = 4f;
            PopTrophy.GetTrophy("学力トロフィー", "学力カンスト", 2);
        }

        //人間力のレーダー位置
        if (PlayerStatus.hu >= 125 && PlayerStatus.hu < 250)
            vert4_step = 0.5f;
        else if (PlayerStatus.hu >= 250 && PlayerStatus.hu < 375)
            vert4_step = 1f;
        else if (PlayerStatus.hu >= 375 && PlayerStatus.hu < 500)
            vert4_step = 1.5f;
        else if (PlayerStatus.hu >= 500 && PlayerStatus.hu < 625)
            vert4_step = 2f;
        else if (PlayerStatus.hu >= 625 && PlayerStatus.hu < 750)
            vert4_step = 2.5f;
        else if (PlayerStatus.hu >= 750 && PlayerStatus.hu < 875)
            vert4_step = 3f;
        else if (PlayerStatus.hu >= 875 && PlayerStatus.hu < 999)
            vert4_step = 3.5f;
        else if (PlayerStatus.hu >= 999)
        {
            vert4_step = 4f;
            PopTrophy.GetTrophy("人間力トロフィー", "人間力カンスト", 3);
        }

        //体力のレーダー位置
        if (PlayerStatus.vi >= 125 && PlayerStatus.vi < 250)
            vert5_step = 0.5f;
        else if (PlayerStatus.vi >= 250 && PlayerStatus.vi < 375)
            vert5_step = 1f;
        else if (PlayerStatus.vi >= 375 && PlayerStatus.vi < 500)
            vert5_step = 1.5f;
        else if (PlayerStatus.vi >= 500 && PlayerStatus.vi < 625)
            vert5_step = 2f;
        else if (PlayerStatus.vi >= 625 && PlayerStatus.vi < 750)
            vert5_step = 2.5f;
        else if (PlayerStatus.vi >= 750 && PlayerStatus.vi < 875)
            vert5_step = 3f;
        else if (PlayerStatus.vi >= 875 && PlayerStatus.vi < 999)
            vert5_step = 3.5f;
        else if (PlayerStatus.vi >= 999)
        {
            vert5_step = 4f;
            PopTrophy.GetTrophy("体力トロフィー", "体力カンスト", 4);
        }

        //運気のレーダー位置
        if (PlayerStatus.lu >= 125 && PlayerStatus.lu < 250)
            vert6_step = 0.5f;
        else if (PlayerStatus.lu >= 250 && PlayerStatus.lu < 375)
            vert6_step = 1f;
        else if (PlayerStatus.lu >= 375 && PlayerStatus.lu < 500)
            vert6_step = 1.5f;
        else if (PlayerStatus.lu >= 500 && PlayerStatus.lu < 625)
            vert6_step = 2f;
        else if (PlayerStatus.lu >= 625 && PlayerStatus.lu < 750)
            vert6_step = 2.5f;
        else if (PlayerStatus.lu >= 750 && PlayerStatus.lu < 875)
            vert6_step = 3f;
        else if (PlayerStatus.lu >= 875 && PlayerStatus.lu < 999)
            vert6_step = 3.5f;
        else if (PlayerStatus.lu >= 999)
        {
            vert6_step = 4f;
            PopTrophy.GetTrophy("運気トロフィー", "運気カンスト", 5);
        }
    }
}
