using UnityEngine;
using System.Collections;

public class PlayerDied : MonoBehaviour
{

    //public Animator childAnimtor;

    private Animator anim;
    public GameObject endmenu;
    public GameObject endmenuFramePos;
    public GameObject endmenuFrame;
    public GameObject ingamedisplay;
    public GameObject buttonup;
    public GameObject buttondown;
    public AudioClip died;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //tag
        if (col.gameObject.CompareTag("Lazer"))
        {
            anim.SetTrigger("died");

            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<Collider2D>().enabled = false;

            endmenu.SetActive(true);
            endmenuFramePos.SetActive(true);
            endmenuFrame.SetActive(true);
            ingamedisplay.SetActive(false);
            buttonup.SetActive(false);
            buttondown.SetActive(false);

            GetComponent<AudioSource>().PlayOneShot(died, 3.0F);

        }
    }
}
