using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabObjectScript : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        // Initialize XRGrabInteractable component
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    void OnEnable()
    {
        // Subscribe to events
        grabInteractable.selectEntered.AddListener(OnSelectEnter);
        grabInteractable.selectExited.AddListener(OnSelectExit);
    }

    void OnDisable()
    {
        // Unsubscribe from events to prevent memory leaks
        grabInteractable.selectEntered.RemoveListener(OnSelectEnter);
        grabInteractable.selectExited.RemoveListener(OnSelectExit);
    }

    private void OnSelectEnter(SelectEnterEventArgs args)
    {
        // Logic for grabbing the object
        Debug.Log("Object Grabbed");
        // Additional logic can be added here for when the object is grabbed
    }

    private void OnSelectExit(SelectExitEventArgs args)
    {
        // Logic for releasing the object
        Debug.Log("Object Released");
        // Additional logic can be added here for when the object is released
    }
}
