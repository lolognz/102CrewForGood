using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class ConverColon : MonoBehaviour
{

    private bool characterIn;
    private GameManagerScene2 gm;

    public GameObject gmObject;
    public string conversation;
    public Flowchart fc;


    void Start()
    {
        this.gm = this.gmObject.GetComponent<GameManagerScene2>();
    }

    void Update()
    {
        if (!this.gm.getIsBlockedDialogue())
        {
            if (characterIn)
            {
                if (Input.GetKeyDown("a") || Input.GetButtonDown("A Button"))
                {

                    this.gm.setBlockDialogue();
                    this.gm.setCanNotMove();
                    this.gm.desactiveButtonA();
                    fc.ExecuteBlock(conversation);

                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Girl")
        {
            characterIn = true;
            this.gm.activeButtonA();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Girl")
        {
            characterIn = false;
            this.gm.desactiveButtonA();
        }
    }
}
