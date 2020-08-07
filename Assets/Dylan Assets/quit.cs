using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class quit : MonoBehaviour
{

    public void clicked()
    {
        Debug.Log("Quiting");
        Application.Quit();
    }
}

