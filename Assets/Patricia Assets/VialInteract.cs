using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VialInteract : MonoBehaviour
{
    public Image win;
    public Animator anim;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<VRTK_InteractableObject>() == null)
        {
            Debug.LogError("Team3_Interactable_Object_Extension is required to be attached to an Object that has the VRTK_InteractableObject script attached to it");
            return;
        }

        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        if (!win.GetComponent<Image>().enabled)
        {
            win.GetComponent<Image>().enabled = true;
            StartCoroutine(ChangeLevel());
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
