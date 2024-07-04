using UnityEngine;

public class ShootDamage : MonoBehaviour
{
    public int scoreValue = 1;
    private GameObject manager;
    private GameManager gameManager;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager");
        gameManager = manager.GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteor"))
        {
            gameManager.AddScore(scoreValue);
            Destroy(collision.gameObject);
            Destruction();




        }

    }

    private void Destruction()
    {
        Destroy(this.gameObject);
    }

}
