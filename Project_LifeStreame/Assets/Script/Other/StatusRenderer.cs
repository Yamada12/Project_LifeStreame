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

    static public float vert1_step = 1f;
    static public float vert2_step = 1f;
    static public float vert3_step = 1f;
    static public float vert4_step = 1f;
    static public float vert5_step = 1f;
    static public float vert6_step = 1f;

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
        vert1_step = 1f;
        vert2_step = 1f;
        vert3_step = 1f;
        vert4_step = 1f;
        vert5_step = 1f;
        vert6_step = 1f;
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
        if (PlayerStatus.co >= 333 && PlayerStatus.co < 666)
        {//コミュ力のレーダー位置
            vert1_step = 2;
        }
        else if (PlayerStatus.co >= 666 && PlayerStatus.co < 999)
        {
            vert1_step = 3;
        }
        else if (PlayerStatus.co >= 900)
        {
            vert1_step = 4;
        }


        if (PlayerStatus.ec >= 333 && PlayerStatus.ec < 666)
        {//経済力のレーダー位置
            vert2_step = 2;
        }
        else if (PlayerStatus.ec >= 666 && PlayerStatus.ec < 999)
        {
            vert2_step = 3;
        }
        else if (PlayerStatus.ec >= 900)
        {
            vert2_step = 4;
        }


        if (PlayerStatus.ac >= 333 && PlayerStatus.ac < 666)
        {//学力のレーダー位置
            vert3_step = 2;
        }
        else if (PlayerStatus.ac >= 666 && PlayerStatus.ac < 999)
        {
            vert3_step = 3;
        }
        else if (PlayerStatus.ac >= 900)
        {
            vert3_step = 4;
        }


        if (PlayerStatus.hu >= 333 && PlayerStatus.hu < 666)
        {//人間力のレーダー位置
            vert4_step = 2;
        }
        else if (PlayerStatus.hu >= 666 && PlayerStatus.hu < 999)
        {
            vert4_step = 3;
        }
        else if (PlayerStatus.hu >= 900)
        {
            vert4_step = 4;
        }


        if (PlayerStatus.vi >= 333 && PlayerStatus.vi < 666)
        {//体力のレーダー位置
            vert5_step = 2;
        }
        else if (PlayerStatus.vi >= 666 && PlayerStatus.vi < 999)
        {
            vert5_step = 3;
        }
        else if (PlayerStatus.vi >= 900)
        {
            vert5_step = 4;
        }


        if (PlayerStatus.lu >= 333 && PlayerStatus.lu < 666)
        {//運のレーダー位置
            vert6_step = 2;
        }
        else if (PlayerStatus.lu >= 666 && PlayerStatus.lu < 999)
        {
            vert6_step = 3;
        }
        else if (PlayerStatus.lu >= 900)
        {
            vert6_step = 4;
        }
    }
}
