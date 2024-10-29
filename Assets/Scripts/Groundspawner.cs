using UnityEngine;
using UnityEditor;

public class Groundspawner : MonoBehaviour
{
    public GameObject groundTile;
    public GameObject ground2;
    public GameObject ground3;
    public GameObject ground4;
    public GameObject groundenemy1;
    public GameObject groundenemy2;

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Trigger"))
        {
            int rand = Random.Range(1, 6);
            
            if(rand == 1) Instantiate(groundTile, new Vector3(0, 0, 20), Quaternion.identity);
            else if (rand == 2) Instantiate(ground2, new Vector3(0, 0, 20), Quaternion.identity);
            else if (rand == 3) Instantiate(ground3, new Vector3(0, 0, 20), Quaternion.identity);
            else if (rand == 4) Instantiate(ground4, new Vector3(0, 0, 20), Quaternion.identity);
            else if (rand == 5) Instantiate(groundenemy1, new Vector3(0, 0, 20), Quaternion.identity);
            else if (rand == 6) Instantiate(groundenemy2, new Vector3(0, 0, 20), Quaternion.identity);

        }
    }
}
