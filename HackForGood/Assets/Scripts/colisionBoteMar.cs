using UnityEngine;
using Fungus;

public class colisionBoteMar : MonoBehaviour {

    private bool onConversation = false;
    private GameManagerBoatMinigame gm;

    public Flowchart fc;


    void Start()
    {
        this.gm = GameObject.Find("GameManager").GetComponent<GameManagerBoatMinigame>();
    }


    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Barco")
        {
            if (this.gameObject.tag == "Perdido")
            {
                fc.ExecuteBlock("BloquePerdido");
            }

            else if (this.gameObject.tag == "Indias")
            {
                fc.ExecuteBlock("BloqueIndias");
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Barco")
        {
            onConversation = false;
        }
    }
}
