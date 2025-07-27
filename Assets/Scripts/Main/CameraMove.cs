using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform moveChar;
    [SerializeField] private Vector3 cameraRotation = new (0,0,-8);

    private void LateUpdate()
    {
        if (!moveChar) return;
        transform.position = moveChar.position + cameraRotation;
    }
}
