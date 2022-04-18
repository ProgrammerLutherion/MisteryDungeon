using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharPueblo_Movement : MonoBehaviour
{
    // Start is called before the first frame update  
    public Animator animator;
    public Rigidbody2D rb;
    public float Movement_Speed = 5f;
    Vector2 movement;
 

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("movement", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * Movement_Speed * Time.fixedDeltaTime);
    }




}
