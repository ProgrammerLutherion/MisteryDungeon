using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    [SerializeField]
    private DungeonGenerator dungeonGenerator;
    [SerializeField]
    public Mainchar_Movement mainchar_movement;
    [SerializeField]
    private float cooldown;
    
    void FixedUpdate()
    {
        if (!mainchar_movement.turno) {
            StartCoroutine(timeout());
            foreach (var enemy in dungeonGenerator.enemies)
            {
                if (enemy.GetComponent<Enemy_Movement>().getHealth() == 0) { 
                dungeonGenerator.enemies.Remove(enemy);
                    Destroy(enemy);
                }else
                    enemy.GetComponent<Enemy_Movement>().Act();
            
        }
        mainchar_movement.turnChange();
        }
    }

    IEnumerator timeout()
    {
        yield return new WaitForSecondsRealtime(cooldown);
    }
}
