using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    [SerializeField]
    private DungeonGenerator dungeonGenerator;
    [SerializeField]
    private Mainchar_Movement mainchar_movement;
    [SerializeField]
    private float cooldown;
    
    void FixedUpdate()
    {
        if (!mainchar_movement.turno) {
            StartCoroutine(timeout());
        foreach (var enemy in dungeonGenerator.enemies)
        {
            enemy.GetComponent<Enemy_Movement>().Move();
        }
        mainchar_movement.turnChange();
        }
    }

    IEnumerator timeout()
    {
        yield return new WaitForSecondsRealtime(cooldown);
    }
}
