using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toNextScene : MonoBehaviour
{
    public Image black;
    public Animator anim;

    public void onClick(int nextScene)
    {
        
        StartCoroutine(Fading(nextScene));
    }
    
    IEnumerator Fading(int nextScene)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(nextScene);
    }
    
}
