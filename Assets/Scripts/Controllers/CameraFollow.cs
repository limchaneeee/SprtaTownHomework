using UnityEngine;

public class CameraFollow : MonoBehaviour 
{
    public Transform target; // 캐릭터의 Transform을 연결할 변수
    public Vector3 offset;   // 카메라와 캐릭터 사이의 거리(오프셋)

    void LateUpdate()
    {
        // 카메라 위치를 캐릭터 위치 + 오프셋으로 설정
        transform.position = target.position + offset;
    }

}