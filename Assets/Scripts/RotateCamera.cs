
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed; // Speed of camera rotation
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); // Rotate the camera around the Y-axis
    }
}
