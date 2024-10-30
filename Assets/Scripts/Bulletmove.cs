using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmove : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody rb;
    public GameObject thisobject;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(thisobject);
        }
    }
    void FixedUpdate()
    {
        Vector3 ForwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + ForwardMove);
    }
}
