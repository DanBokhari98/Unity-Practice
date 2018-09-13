using UnityEngine;
public class PlayerCollision : MonoBehaviour {

    public PlayerMovement Movement;
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {
            Movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
        }
        
    }

}
