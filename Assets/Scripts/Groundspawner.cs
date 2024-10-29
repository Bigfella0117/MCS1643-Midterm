using UnityEngine;
using UnityEditor;

public class Groundspawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(groundTile, new Vector3(0,0,0), Quaternion.identity);
        }
    }
}
