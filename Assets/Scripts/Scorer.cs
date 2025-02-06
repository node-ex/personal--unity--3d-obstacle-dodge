using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        bool collisionWithObstacle = collision.gameObject.CompareTag("Obstacle");
        if (collisionWithObstacle)
        {
            score += 1;
            Debug.Log("Score: " + score);
        }
    }
}
