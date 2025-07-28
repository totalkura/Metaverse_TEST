using UnityEngine;

public class InGameCamera : MonoBehaviour
{
    [SerializeField] private Transform moveChar;
    [SerializeField] private Vector3 cameraRotation;

    float offsetX;

    private void Start()
    {
        if (!moveChar) return;

        offsetX = transform.position.x - moveChar.position.x;
    }

    private void Update()
    {
        if (!moveChar) return;

        cameraRotation = transform.position;
        cameraRotation.x = moveChar.position.x + offsetX;
        transform.position = cameraRotation;
    }
}
