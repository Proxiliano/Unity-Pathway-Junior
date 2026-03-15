
using UnityEngine;

public class Target : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
   private Rigidbody targetRb;
   public int pointValue;
   private GameManager gameManager;
   public ParticleSystem explosionParticle;
    // Start is called before the first frame update

   void Start()
    {
        if (isGameActive = true)
        {
            gameOverText = GameObject.Find("Game Over Text").GetComponent<TextMeshProUGUI>();
        }
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse); 
        transform.position = new Vector3(Random.Range(-4, 4), -6);
        
    }
    private void OnMouseDown()
    {
        if (gameManager.isGameActive)
        {
        gameManager.UpdateScore(pointValue);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);   
        Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
        Destroy(gameObject);
    }
    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
    }
}
