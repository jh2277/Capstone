using UnityEngine;

public class OculusHeadMovement : MonoBehaviour
{
    public Transform headAnchor;

    private void Update()
    {
        // Oculus ������ �Ӹ� �������� �����Ͽ� ī�޶� ������ ����
        transform.position = headAnchor.position;
        transform.rotation = headAnchor.rotation;
    }
}
