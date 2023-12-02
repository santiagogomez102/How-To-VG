using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Time.deltaTime to depend on time, not frames
    public Rigidbody rb;
    public float forwardForce = 2000;

    void Start()
    {
        
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
