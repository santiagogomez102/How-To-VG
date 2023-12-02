using UnityEngine;
public class PlayerMovement : MonoBehaviour{
    public Rigidbody rb;
    public float forwardForce = 200;
    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
    }
}
