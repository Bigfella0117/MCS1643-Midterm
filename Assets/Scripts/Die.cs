using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public string SceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle") || other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
        }
        
    }

    
    
}
