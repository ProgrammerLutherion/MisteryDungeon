using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    [SerializeField]
    private GameObject pj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(pj.transform.position == collision.transform.position)
        SceneManager.LoadScene("Dungeon");
    }
}
