using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Text code;
    public string answer = "1234";
    
    void Start()
    {
        code.text = "";
    }

    // Update is called once per frame
    public void clickKey(string character)
    {

        code.text += character;
    }
    private void Update()
    {
        if(code.text == answer)
        {
            code.text = "You Win!";
        }
    }
}
