using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharPueblo_Movement : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }

    public Animator animator;
    public Rigidbody2D rb;
    public float Movement_Speed = 5f;
    Vector2 movement;
 

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("movement", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.E) && dialogueUI.IsOpen == false)
        {
            if (Interactable != null)
            {
                Interactable.Interact(this);
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * Movement_Speed * Time.fixedDeltaTime);
    }

    public void SetDialogueUI(DialogueUI dialogue)
    {
        dialogueUI = dialogue;
    }




}
