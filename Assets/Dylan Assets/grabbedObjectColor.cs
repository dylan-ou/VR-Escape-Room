using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbedObjectColor : MonoBehaviour
{
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Grabber")
        {
            rend.material.color = new Color(1, 1, 1, 0.01f);
        }
    }
}
