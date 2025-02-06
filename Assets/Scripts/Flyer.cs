using UnityEngine;

public class Flyer : MonoBehaviour
{
    [SerializeField] GameObject player = null;
    [SerializeField] float flySpeed = 0f;
    Vector3 targetPosition;

    void Start()
    {
        targetPosition = player.transform.position;
    }

    void Update()
    {
        FlyToTarget();
        DestroySelfWhenTargetReached();
    }

    void FlyToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, flySpeed * Time.deltaTime);
    }

    void DestroySelfWhenTargetReached()
    {
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
