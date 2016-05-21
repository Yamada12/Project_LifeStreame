using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    public float Max = 10; //最大値
    public float count = 0; //最小値
    public GameObject game;
    bool flg;

    void Start()
    {
        flg = true;
    }
    void Update()
    {
        // 左クリックしたら
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //マウスクリックした場所からRay？を飛ばし、オブジェクトがあればtrue 
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);
                
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                    count = count + 1;
                    if (Max == count)
                    {
                        Destroy(game.gameObject); 
                    }
                   // flg = !flg;
                }
            }

        }
    }	
}
