using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScene : MonoBehaviour
{
    public String SceneName; 
    private void OnTriggerEnter(Collider collision)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            /*Debug.Log(collision.gameObject.name);
            DontDestroyOnLoad(collision.gameObject);       */         
            SceneManager.LoadScene(SceneName,LoadSceneMode.Single);            
        }
    }
}
