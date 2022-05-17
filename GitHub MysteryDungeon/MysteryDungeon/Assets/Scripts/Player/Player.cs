using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player : MonoBehaviour
{
    [SerializeField] protected int Health, AttackDamage, Armor, Money;
    private ItemObject[] items;

    public IInteractable Interactable { get; set; }
    
    public int getHealth()
    {
        return Health;
    }
    public int getAttackDamage()
    {
        return AttackDamage;
    }
    public int getArmor()
    {
        return Armor;
    }

    public void takeDamage(int damage)
    {
        if (Health - damage <= 0)
            Health = 0;
        else
            Health -= damage;
    }

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


