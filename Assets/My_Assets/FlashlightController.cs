using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    private Light flashlight;

    void Start()
    {
        // Assuming the flashlight is a child of the GameObject with this script
        flashlight = GetComponentInChildren<Light>();

        // Ensure flashlight is initially off
        flashlight.enabled = false;
    }

    void Update()
    {
        // Toggle the flashlight on/off when the "F" key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }
    }

    void ToggleFlashlight()
    {
        flashlight.enabled = !flashlight.enabled;
    }
}
