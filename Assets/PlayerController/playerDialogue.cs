using UnityEngine;
using UnityEngine.InputSystem;

public class playerDialogue : MonoBehaviour
{
    public GameObject interactText;
    public GameObject dialogue1;
    public LayerMask layerMask;

    void Start()
    {
        dialogue1.SetActive(false);
        interactText.SetActive(false);
    }
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 4f, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Hit");
            interactText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && dialogue1.activeInHierarchy == false){
                dialogue1.SetActive(true);
            }
            else if (Input.GetKeyDown(KeyCode.E) && dialogue1.activeInHierarchy == true)
            {
                dialogue1.SetActive(false);
            }
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Not Hit");
            interactText.SetActive(false);
        }
    }
}
