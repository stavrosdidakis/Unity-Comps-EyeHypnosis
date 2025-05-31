using UnityEngine;

public class SmoothRandomRotation : MonoBehaviour
{
    public float rotationSpeed = 30f; // Degrees per second
    public float directionChangeInterval = 2f;

    private Vector3 currentRotationAxis;
    private Vector3 targetRotationAxis;
    private float timeSinceLastChange;

    void Start()
    {
        currentRotationAxis = GetRandomAxis();
        targetRotationAxis = GetRandomAxis();
    }

    void Update()
    {
        timeSinceLastChange += Time.deltaTime;

        // Smoothly interpolate between rotation directions
        currentRotationAxis = Vector3.Slerp(currentRotationAxis, targetRotationAxis, Time.deltaTime);

        // Apply rotation
        transform.Rotate(currentRotationAxis * rotationSpeed * Time.deltaTime, Space.Self);

        // Occasionally change direction
        if (timeSinceLastChange > directionChangeInterval)
        {
            targetRotationAxis = GetRandomAxis();
            timeSinceLastChange = 0f;
        }
    }

    Vector3 GetRandomAxis()
    {
        return new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;
    }
}
