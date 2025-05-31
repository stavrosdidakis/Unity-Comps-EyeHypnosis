using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;          // The object to orbit around
    public float orbitSpeed = 20f;    // Degrees per second
    public float radius = 5f;         // Orbit distance from the target
    public Vector3 orbitAxis = Vector3.up; // Axis to orbit around (usually Vector3.up)

    private float currentAngle = 0f;

    void Update()
    {
        if (target == null) return;

        // Update the current angle based on orbit speed and time
        currentAngle += orbitSpeed * Time.deltaTime;
        currentAngle %= 360f;

        // Calculate the new position around the target
        Vector3 offset = Quaternion.AngleAxis(currentAngle, orbitAxis) * (Vector3.forward * radius);
        transform.position = target.position + offset;

        // Make sure the camera always looks at the target
        transform.LookAt(target);
    }
}
