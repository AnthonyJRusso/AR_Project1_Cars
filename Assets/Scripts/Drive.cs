using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class Drive : MonoBehaviour
{
    ARGestureInteractor arGestureInteractor;
    ARSelectionInteractable arSelectionInteractable;
    public float speed;
    public Rigidbody rb;

    void OnEnable()
    {
        arGestureInteractor = GetComponent<ARGestureInteractor>();
        

        arSelectionInteractable = GetComponent<ARSelectionInteractable>();
        //If car is selected
        arSelectionInteractable.selectEntered.AddListener(OnSelectCar);
    }

    private void OnSelectCar(SelectEnterEventArgs args)
    {
        rb.velocity += transform.forward * speed;
    }
}
