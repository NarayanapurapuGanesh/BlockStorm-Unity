using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveForce = 10f;   // Force applied for movement
    public float maxSpeed = 8f;     // Maximum movement speed

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");

        // Move while key is pressed
        if (moveX != 0 || moveZ != 0)
        {
            Vector3 moveDir = new Vector3(moveX, 0, moveZ).normalized;
            rb.AddForce(moveDir * moveForce, ForceMode.Force);

            // Limit max speed
            Vector3 flatVel = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            if (flatVel.magnitude > maxSpeed)
            {
                flatVel = flatVel.normalized * maxSpeed;
                rb.velocity = new Vector3(flatVel.x, rb.velocity.y, flatVel.z);
            }
        }
        else
        {
            // Stop immediately when no key is pressed
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            rb.angularVelocity = Vector3.zero; // Stop rotation too
        }
    }
}
