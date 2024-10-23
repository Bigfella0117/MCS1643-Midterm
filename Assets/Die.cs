using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    public string SceneName;
    public Collider thisobj;
    private void OnTriggerEnter(Collider thisobj)
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
        
    }
}
