using UnityEngine;
public class PlayerMovement : MonoBehaviour{
    public Rigidbody rb;
    public float forwardForce = 200f;
    public float sidewaysForce = 200f;
    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
