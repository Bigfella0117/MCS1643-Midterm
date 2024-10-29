using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject thisobject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bullet")) Destroy(thisobject);
    }

}