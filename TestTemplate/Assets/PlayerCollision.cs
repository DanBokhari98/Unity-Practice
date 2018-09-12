using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement Movement;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {
            Movement.enabled = false;
        }
        
    }

}
