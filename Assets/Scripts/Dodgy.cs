using UnityEngine;
using UnityEngine.SceneManagement;

public class Dodgy : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float thresholdYPositionForLevelReset = -10f;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
        ResetLevel();
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

    void ResetLevel()
    {
        if (transform.position.y < thresholdYPositionForLevelReset)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
