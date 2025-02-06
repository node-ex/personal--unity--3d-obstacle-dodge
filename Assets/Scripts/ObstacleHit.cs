using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag != "Obstacle_Hit")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            /* Change own tag */
            gameObject.tag = "Obstacle_Hit";
        }
    }
}
