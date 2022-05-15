using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    [SerializeField]
    private GameObject pj;
    [SerializeField]
    private DungeonGenerator dg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (pj.transform.position == collision.transform.position) {
            pj.transform.position = new Vector3 ((float) 0.5,(float) 0.5, pj.transform.position.z);
            dg.load();
        }

    }
}
