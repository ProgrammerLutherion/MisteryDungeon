using UnityEngine;

public class DialogActivator : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueObject dialogueObject;

    public void UpdateDialogueObject(DialogueObject dialogueObject)
    {
        this.dialogueObject = dialogueObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && collision.TryGetComponent(out MainCharPueblo_Movement player))
        {
            player.Interactable = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.TryGetComponent(out MainCharPueblo_Movement player))
        {
            if(player.Interactable is DialogActivator dialogActivator && dialogActivator == this)
            {
                player.Interactable = null;
            }
        }

    }

    public void Interact(MainCharPueblo_Movement player)
    {
        if(TryGetComponent(out DialogueResponseEvents responseEvents) && responseEvents.DialogueObject == dialogueObject)
        {
            player.DialogueUI.AddResponseEvents(responseEvents.Events);
        }

        player.DialogueUI.ShowDialogue(dialogueObject);
    }
}
