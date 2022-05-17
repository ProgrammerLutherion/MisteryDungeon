using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToScene : MonoBehaviour
{
    public String SceneName;
    public Vector3 spawnpos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log(collision.gameObject.name);
            DontDestroyOnLoadManager.DontDestroyOnLoad(collision.gameObject);
            collision.gameObject.transform.position = new Vector3(0, 0, -21);
            SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
        }
    }
}
