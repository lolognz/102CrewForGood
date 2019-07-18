using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class conversationLaunch : MonoBehaviour {

	private bool characterIn;
    private moveGirl moveGirlScript;
    private bool conversation1Active = true;
    private bool conversation2Active = false;
    private bool blockDialogue = false;

    public GameObject girlPlayer;
	public string conversation;
    public string conversation2;
    public Flowchart fc;
	// Use this for initialization
	void Start () {
        this.moveGirlScript = this.girlPlayer.GetComponent<moveGirl>();
    }
	
	// Update is called once per frame
	void Update () {
        if (!this.blockDialogue) { 
		    if (characterIn) {
			    if (Input.GetKeyDown ("a") || Input.GetButtonDown("A Button")) {
                    if (conversation1Active) {
                        Debug.Log ("Primera conver lanzada");
                        this.conversation1Active = false;
                        this.conversation2Active = true;
                        this.blockDialogue = true;
                        this.moveGirlScript.activeButtonA(false);
                        this.moveGirlScript.setCanMove(false);
				        fc.ExecuteBlock (conversation);
                    }
                }
		    }
        }
    }

    public void launchSecondConversation()
    {
           if (conversation2Active) { 
            Debug.Log("Segunda conver lanzada");
            this.conversation2Active = false;
            this.blockDialogue = true;
            this.moveGirlScript.activeButtonA(false);
            this.moveGirlScript.setCanMove(false);
            fc.ExecuteBlock(conversation2);
        }
    }

	void OnTriggerEnter2D(Collider2D col) {
        if (col.tag == "Girl")
        {
            characterIn = true;
            this.moveGirlScript.activeButtonA(true);
        }
    }

	void OnTriggerExit2D(Collider2D col) {
        if (col.tag == "Girl")
        {
            characterIn = false;
            this.moveGirlScript.activeButtonA(false);
        }
	}

    public bool getIsBlockedDialogue()
    {
        return this.blockDialogue;
    }

    public void setBlockDialogue(bool b)
    {
        this.blockDialogue = b;
    }
}
