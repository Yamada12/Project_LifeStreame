using UnityEngine;

public class TapEffect : MonoBehaviour
{
    [SerializeField]
    ParticleSystem tapEffect;              // タップエフェクト
    [SerializeField]
    Camera _camera;                        // カメラの座標

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // マウスのワールド座標までパーティクルを移動し、パーティクルエフェクトを1つ生成する
            var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);
            tapEffect.transform.position = pos;
            tapEffect.startRotation = 0;
            tapEffect.Emit(1);
            Invoke("tap02", 0.2f);
        }
    }

    void tap02()
    {
        tapEffect.startRotation = 150;
        tapEffect.Emit(1);
    }
}