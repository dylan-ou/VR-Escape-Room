using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlicker : MonoBehaviour
{
    // Start is called before the first frame update
    Light light;
    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(flash());
    }

    // Update is called once per frame
    IEnumerator flash()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 10f));
            light.enabled = !light.enabled;
            yield return new WaitForSeconds(0.5f);
            light.enabled = !light.enabled;
        }
    }
}
