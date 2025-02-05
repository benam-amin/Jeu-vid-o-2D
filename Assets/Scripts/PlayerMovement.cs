using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f; 
    public float moveDirectionX = 0f;
    public float jumpForce = 7f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirectionX = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
    }

    private void Jump() {
        rb.linearVelocity = new Vector2 (
            rb.linearVelocity.x,
            jumpForce
        );
    }
    private void FixedUpdate() {
        rb.linearVelocity = new Vector2 (
            moveDirectionX * moveSpeed,
            rb.linearVelocity.y
        );
    }
}
