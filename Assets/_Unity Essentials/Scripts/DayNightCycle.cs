using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The duration in seconds for a full day to pass
    [Tooltip("Duration in seconds for a full day to pass")]
    public float dayDuration = 120f; // Default: 120 seconds (2 minutes for a full day)

    private float rotationSpeed;

    void Start()
    {
        // Calculate the speed at which the light should rotate to complete a full circle (360 degrees)
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate the sun moving in the sky
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
