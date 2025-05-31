using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightHueRotator : MonoBehaviour
{
    public float hueSpeed = 0.1f; // Speed of hue rotation (0.1 = full cycle in 10 seconds)
    public float saturation = 1f; // Keep full saturation for vivid color
    public float value = 1f;      // Keep full brightness

    private Light targetLight;
    private float currentHue = 0f;

    void Start()
    {
        targetLight = GetComponent<Light>();
    }

    void Update()
    {
        currentHue += hueSpeed * Time.deltaTime;
        currentHue %= 1f; // Wrap hue between 0 and 1

        Color newColor = Color.HSVToRGB(currentHue, saturation, value);
        targetLight.color = newColor;
    }
}
