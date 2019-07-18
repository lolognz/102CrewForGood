using UnityEngine;

public class activeBook : MonoBehaviour {

    private Animator anim;
    private conversationLaunch converLaunch;
    private AudioSource aud;

    public GameObject flujoConver;
    public AudioClip teleportEffect;

	void Start () {
        this.anim = this.gameObject.GetComponent<Animator>();
        this.converLaunch = this.flujoConver.GetComponent<conversationLaunch>();
        this.aud = this.gameObject.GetComponent<AudioSource>();
	}

    public void activeBorrar()
    {
        this.aud.Play();
        this.anim.SetBool("Borrar", true);
    }

    public void activeAbsorber()
    {
        this.aud.Stop();
        this.aud.clip = this.teleportEffect;
        this.aud.Play();
        this.anim.SetBool("Absorber", true);
    }

    public void lanzarSegundaConver()//Lanzada desde la animacion del libro
    {
        this.converLaunch.launchSecondConversation();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Girl")
        {
            this.anim.SetBool("Brillar", true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Girl")
        {
            this.anim.SetBool("Brillar", false);
        }
    }
}