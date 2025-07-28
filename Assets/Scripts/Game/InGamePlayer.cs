using UnityEngine;

public class InGamePlayer : MonoBehaviour
{
    Rigidbody2D _rigidbody;

    public bool deathCheck = false;
    public float moveSpeed = 3f;
    public float jumpHigh = 3f;

    bool jump = false;

    InGameManager inGameManager;

    void Start()
    {
        inGameManager = InGameManager.Instance;

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!deathCheck)
        {
            if (Input.GetMouseButtonDown(0))
            {
                jump = true;
            }
        }


    }

    private void FixedUpdate()
    {
        if (deathCheck) return;

        Vector3 velocity = _rigidbody.velocity;
        velocity.x = moveSpeed;

        if(jump)
        {
            velocity.y = jumpHigh;
            jump = false;
        }

        _rigidbody.velocity = velocity;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (deathCheck) return;
        deathCheck = true;
        inGameManager.Gameover();
    }
}
