using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private float move_Speed = 3f;

    private AnimationHandler animationHandler;

    public bool npc = false;

    void Awake()
    {
        animationHandler = GetComponentInChildren<AnimationHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pushInput = GetInputmove();
        animationHandler.Move(pushInput);
        MoveCharacter(pushInput);

        if (npc)
        {
            if (Input.GetKeyDown(KeyCode.F))
                SceneManager.LoadScene("GameScene");
        }
    }

    Vector2 GetInputmove()
    {
        float left_right = Input.GetAxis("Horizontal");
        float up_down = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(left_right, up_down);

        if (Mathf.Abs(move.x) > Mathf.Abs(move.y)) move.y = 0;  
        else move.x = 0;

        return move;
    }

    void MoveCharacter(Vector2 direction)
    {
        Vector3 moves = new Vector3 (direction.x, direction.y,0);
        transform.position += moves * move_Speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC")) npc = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("NPC")) npc = false;
    }

}
