using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                if (collider.TryGetComponent(out NPCInteract npcInteract)) {
                    npcInteract.Interact();
                }
            }
        }
    }
}
