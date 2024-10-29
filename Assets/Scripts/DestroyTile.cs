using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTile : MonoBehaviour
{
    public GameObject thisobject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Destroyer")) Destroy(thisobject);
    }
}
