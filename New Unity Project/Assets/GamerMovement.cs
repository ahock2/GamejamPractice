using UnityEngine;

public class GamerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Update is called once per frame
    float force = 20.0f;
    float jumpforce = 400.0f;
    bool jump = false;
    void OnCollisionEnter(Collision collision)
    {
        jump = true;
    }
    void FixedUpdate ()
    {
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey("a"))
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey("d"))  
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //if (Input.GetKey("space") && rb.position.y < 0.51f && rb.position.y > 0.48f)
        if (Input.GetKey("space") && jump)
        {
            jump = false;
            rb.AddForce(0, jumpforce * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
}
