using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy")) // Compare the tag of the collided GameObject
        {
            /*
            HealthManager.health--;
            if (HealthManager.health <= 0)
            {
                Debug.Log("Game over");
            }*/
        }
    }
}
