using UnityEngine;

public class Dodgy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Use the arrow keys to move the player.");
    }

    void MovePlayer()
    {
        float horizontalAxisValue = Input.GetAxis("Horizontal");
        float verticalAxisValue = Input.GetAxis("Vertical");

        float translateXValue = moveSpeed * horizontalAxisValue * Time.deltaTime;
        float translateYValue = 0f;
        float translateZValue = moveSpeed * verticalAxisValue * Time.deltaTime;
        transform.Translate(translateXValue, translateYValue, translateZValue);
    }
}
