using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float highY = 1f;
    public float lowY = -1f;

    public float SizeMin = 1f;
    public float SizeMax = 2f;

    public Transform Bullet;
    public Transform Bullet_;

    public float widthPadding = 4f;

    InGameManager ingameManamger;

    private void Start()
    {
        ingameManamger = InGameManager.Instance; 
    }

    public Vector3 SetRandomPlace(Vector3 lastPosition, int obstaclCount)
    {
        float holeSize = Random.Range(SizeMin,SizeMax);
        float halfSize = holeSize / 2;

        Bullet.localPosition = new Vector3(0, halfSize);
        Bullet_.localPosition = new Vector3(0, -halfSize);

        Vector3 placePosition = lastPosition + new Vector3(widthPadding, 0);
        placePosition.y = Random.Range(lowY, highY);

        transform.position = placePosition;

        return placePosition;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        InGamePlayer player = collision.GetComponent<InGamePlayer>();
        if (player != null)
            ingameManamger.AddScore(1);
    }
}
