using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class buttonPress2 : MonoBehaviour
{
    public Text code;
    public string input = "";

    VRTK_InteractableObject vrt;

    // Start is called before the first frame update
    void Start()
    {
        code.text = "";
        vrt = GetComponent<VRTK_InteractableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vrt.IsTouched())
        {
            Debug.Log("FUCK");
        }
        if (vrt.IsUsing())
        {
            Debug.Log("In here!");
            code.text += input;
        }
    }
}
