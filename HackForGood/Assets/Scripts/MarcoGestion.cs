using UnityEngine.UI;
using UnityEngine;

public class MarcoGestion : MonoBehaviour {

    public GameObject anio;
    public GameObject ciudad;

    private Animator anioAnim;
    private Animator ciudadAnim;
    private AudioSource aud;

    private bool sonidoCiudad = false;
    private bool sonidoAnio = false;

    void Start()
    {
        this.anioAnim = this.anio.GetComponent<Animator>();
        this.ciudadAnim = this.ciudad.GetComponent<Animator>();
        this.aud = this.gameObject.GetComponent<AudioSource>();
    }

    public void ActivarAnio()
    {
        if (!sonidoAnio)
            this.playEffect();

        sonidoAnio = true;
        this.anioAnim.SetBool("Aparecer", true);
    }

    public void ActivarCiudad()
    {
        if (!sonidoCiudad)
            this.playEffect();

        sonidoCiudad = true;
        this.ciudadAnim.SetBool("Aparecer", true);
    }

    public void playEffect()    //En eventos
    {
        this.aud.Play();
    }
}