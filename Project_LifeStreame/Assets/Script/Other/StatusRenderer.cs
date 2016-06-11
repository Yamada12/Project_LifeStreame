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

    void Start()
    {
        DefaultVerts();
        UpdateMesh();
    }

    void Update()
    {
        UpdateMesh();
    }

    public void UpdateMesh()
    {//メッシュの形を更新する
        mesh = new Mesh();
        mesh.vertices = new Vector3[]
        {
            vert1,
            vert2,
            vert3,
            vert4,
            vert5,
            vert6,
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
}
