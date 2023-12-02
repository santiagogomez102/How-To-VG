using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 200);
    }
}
