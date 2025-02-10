using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
   public Rigidbody2D rb;
   public BoxCollider2D bc;
   public LayerMask listObstacleLayers;
   public float groundCheckRadius = 0.15f;
   public float moveSpeed = 3f;
   public void FixedUpdate() {
    rb.linearVelocity = new Vector2 ( //deplacement automatique vers la droite 
        moveSpeed * transform.right.normalized.x,
        rb.linearVelocityY
    );

   }

    bool HasNotTouchedGround() {
        Vector2 detectionPosition = new Vector2(
            bc.bounds.center.x + (transform.right.normalized.x * bc.bounds.size.x/2),
            bc.bounds.min.y
        ); 
        return !Physics2D.OverlapCircle(
            detectionPosition,
            groundCheckRadius,
            listObstacleLayers
        );
    }
}
