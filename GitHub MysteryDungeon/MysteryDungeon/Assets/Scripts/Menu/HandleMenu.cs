using UnityEngine;

public class HandleMenu : MonoBehaviour
{
    void OnGUI()
    {
        // We will only show the menu if displayMenu is true
        // and there is a menuTarget. This will prevent problems if
        // we forget to send the MenuManager the GameObject that was clicked on.
        if (MenuManager.displayMenu && MenuManager.menuTarget)
        {
            Vector2 position = GetComponent<Camera>().WorldToScreenPoint(MenuManager.menuTarget.transform.position);

            GUILayout.BeginArea(new Rect(position.x, position.y, 128, 80), GUI.skin.box);

            GUILayout.Label("Commands");

            if (GUILayout.Button("Attack"))
            {

                if (MenuManager.menuTarget.GetComponent<Enemy_Movement>().isInRange)
                {
                MenuManager.displayMenu = false;
                Debug.Log("Attack!");
                }
                else
                {
                    Debug.Log("No estás en rango");
                }


                MenuManager.menuTarget = null;
            }

            if (GUILayout.Button("Cancel"))
            {
                MenuManager.displayMenu = false;
                MenuManager.menuTarget = null;
            }

            GUILayout.EndArea();
        }
    }
}