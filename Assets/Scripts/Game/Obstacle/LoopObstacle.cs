using UnityEngine;

public class LoopObstacle : MonoBehaviour
{
    public int numCount = 5;

    public int obstacleCount = 0;
    public Vector3 obstacleLastPosition = Vector3.zero;

    void Start()
    {
        Obstacle[] obstacles = GameObject.FindObjectsOfType<Obstacle>();
        obstacleLastPosition = obstacles[0].transform.position;
        obstacleCount = obstacles.Length;

        for (int i = 0; i < obstacleCount; i++)
        {
            obstacleLastPosition = obstacles[i].SetRandomPlace(obstacleLastPosition, obstacleCount);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BackGround"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * numCount;
            collision.transform.position = pos;
            return;
        }

        Obstacle obstacle = collision.GetComponent<Obstacle>();
        if (obstacle)
        {
            obstacleLastPosition = obstacle.SetRandomPlace(obstacleLastPosition, obstacleCount);
        }

    }
}
