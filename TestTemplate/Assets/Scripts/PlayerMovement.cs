using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float initialForce = 200f;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
	// Use this for initialization
	
	// Update is called once per frame
    //We changed it from Update to FixedUpdate for physics based methods
	void FixedUpdate () {
        //add A Forward force
        rb.AddForce(0, 0, (initialForce * Time.deltaTime) + 20f);
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w")) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0,-forwardForce * Time.deltaTime);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
