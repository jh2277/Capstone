using UnityEngine;

public class OculusHeadMovement : MonoBehaviour
{
    public Transform headAnchor;

    private void Update()
    {
        // Oculus 헤드셋의 머리 움직임을 감지하여 카메라 시점을 제어
        transform.position = headAnchor.position;
        transform.rotation = headAnchor.rotation;
    }
}
