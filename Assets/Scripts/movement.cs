using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class movement : MonoBehaviour
{
    public float force = 2.0f;
    public Vector3 jump;
    public bool isgrounded;
    public bool isducking;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }

    private void OnCollisionStay(Collision collision)
    {
        isgrounded = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isgrounded)
        {
            rb.AddForce(jump * force, ForceMode.Impulse);
            isgrounded = false;
        }
    }
}
