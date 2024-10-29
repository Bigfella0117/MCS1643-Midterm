using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float speed = -6f;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 ForwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + ForwardMove);
    }
}
