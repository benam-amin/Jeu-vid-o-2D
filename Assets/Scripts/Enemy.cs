using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ContactPoint2D [] listContacts = new ContactPoint2D[1];
    
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) { //comparetag beaucoup plus performant
            other.GetContacts(listContacts);
            if (listContacts[0].normal.y < -0.5f) { //est détruit si on lui saute dessus
                Destroy(gameObject);
            } else {
                PlayerHealth dataPlayer = other.gameObject.GetComponent<PlayerHealth>();
                dataPlayer.Hurt();
            } 
        }
    }
}
