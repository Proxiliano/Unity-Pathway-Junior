using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject focalPoint; // Reference to the focal point for camera rotation
    private Rigidbody playerRb;
    public float speed = 5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point"); // Find the focal point in the scene
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrow keys)
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed); // Move the player forward/back
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject); // Destroy the powerup object
        }
    }
}
