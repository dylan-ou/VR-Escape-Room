using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exitLevel : MonoBehaviour
{
    public bool isEntered;

    public Image win;
    public Animator anim;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            isEntered = true;
            if (!win.GetComponent<Image>().enabled)
            {
                win.GetComponent<Image>().enabled = true;
                StartCoroutine(ChangeLevel());
            }

        }
        else
        {
            isEntered = false;
        }
    }

    IEnumerator ChangeLevel()
    {
        anim.SetBool("Fade", true);
        audioSource.Play();
        yield return new WaitUntil(() => win.color.a == 1 && !audioSource.isPlaying);
        SceneManager.LoadScene(1);
    }
}
