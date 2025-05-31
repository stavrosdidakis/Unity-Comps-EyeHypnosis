using UnityEngine;

public class SmoothFlyMotion : MonoBehaviour
{
    public float speed = 2.0f;
    public float noiseScale = 1.0f;
    public float boundarySize = 5.0f;

    private Vector3 noiseOffset;

    void Start()
    {
        // Randomize noise offsets so each fly has different movement
        noiseOffset = new Vector3(Random.value * 100f, Random.value * 100f, Random.value * 100f);
    }

    void Update()
    {
        // Time-based Perlin noise input for each axis
        float time = Time.time * noiseScale;

        // Generate smooth directional noise values
        float x = Mathf.PerlinNoise(noiseOffset.x, time) * 2f - 1f;
        float y = Mathf.PerlinNoise(noiseOffset.y, time) * 2f - 1f;
        float z = Mathf.PerlinNoise(noiseOffset.z, time) * 2f - 1f;

        Vector3 direction = new Vector3(x, y, z).normalized;

        // Move smoothly in noisy direction
        transform.position += direction * speed * Time.deltaTime;

        // Keep within boundaries
        Vector3 clampedPosition = new Vector3(
            Mathf.Clamp(transform.position.x, -boundarySize, boundarySize),
            Mathf.Clamp(transform.position.y, -boundarySize, boundarySize),
            Mathf.Clamp(transform.position.z, -boundarySize, boundarySize)
        );
        transform.position = clampedPosition;
    }
}
