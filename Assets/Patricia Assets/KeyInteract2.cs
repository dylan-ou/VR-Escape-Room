using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class KeyInteract2 : MonoBehaviour
{
    public GameObject top;
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError("Team3_Interactable_Object_Extension is required to be attached to an Object that has the VRTK_InteractableObject script attached to it");
            return;
        }

        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
    }

    // Update is called once per frame
    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        top.SetActive(false);
    }
}
