using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public Transform theDest;
    public float rotSpeed = 50f;
    public float minDist = 1.5f;

    bool mouseMove = false;

    private void Start()
    {
        this.GetComponent<Rigidbody>().useGravity = true;
    }

    private void OnMouseDown()
    {
        if ((transform.position - theDest.position).magnitude <= minDist)
        {
            mouseMove = true;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }
    }

    private void OnMouseUp()
    {
        if ((transform.position - theDest.position).magnitude <= minDist)
        {
            mouseMove = false;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;
            this.transform.parent = null;
            this.transform.position = theDest.transform.position;
        }
    }
}
