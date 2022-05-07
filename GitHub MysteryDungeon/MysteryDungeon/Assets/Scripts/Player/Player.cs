using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    [SerializeField] protected int Health, AttackDamage, Armor, Money;
    private ItemObject[] items;

    public IInteractable Interactable { get; set; }

    [SerializeField] private DialogueUI dialogueUI;
    [SerializeField] protected GameObject panel;
    public DialogueUI DialogueUI => dialogueUI;

    public virtual void openInventory()
    {
        if (Input.GetKeyDown(KeyCode.I) && dialogueUI.IsOpen == false)
        {
            if(panel.active == false)
            {
                panel.SetActive(true);
            }
            else
            {
                panel.SetActive(false);
            }          
        }
    }

    public virtual void startDialogue()
    {
        if (Input.GetKeyDown(KeyCode.E) && dialogueUI.IsOpen == false)
        {
            if (Interactable != null)
            {
                Interactable.Interact(this);
            }
        }
    }

    public virtual void SetDialogueUI(DialogueUI dialogue)
    {
        dialogueUI = dialogue;
    }
}


