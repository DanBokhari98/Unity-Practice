using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
    public float opponentForce = 100f;
    public Rigidbody rb;
    private void FixedUpdate()
    {
      rb.AddForce(0, 0, (-opponentForce * Time.deltaTime) - 20f);
    }
}
