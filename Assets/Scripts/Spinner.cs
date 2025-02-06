using UnityEngine;

public class Spinner : MonoBehaviour
{
    /* 360f */
    [SerializeField] float spinSpeedOverXAxis = 0f;
    [SerializeField] float spinSpeedOverYAxis = 0f;
    [SerializeField] float spinSpeedOverZAxis = 0f;

    void Update()
    {
        Spin();
    }

    void Spin()
    {
        float xRotationValue = spinSpeedOverXAxis * Time.deltaTime;
        float yRotationValue = spinSpeedOverYAxis * Time.deltaTime;
        float zRotationValue = spinSpeedOverZAxis * Time.deltaTime;

        transform.Rotate(xRotationValue, yRotationValue, zRotationValue);
    }
}
