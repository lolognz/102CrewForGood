using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScene2 : MonoBehaviour {

    public GameObject girlPlayer;

    private movePlayer movePlayerScript;
    private bool blockDialogue = false;

	void Start () {
        this.movePlayerScript = this.girlPlayer.GetComponent<movePlayer>();
	}

    public bool getIsBlockedDialogue()
    {
        return this.blockDialogue;
    }

    public void setBlockDialogue()
    {
        this.blockDialogue = true;
    }

    public void setNotBlockDialogue()
    {
        this.blockDialogue = false;
    }

    public void setCanMove()
    {
        this.movePlayerScript.setCanMove();
    }

    public void setCanNotMove()
    {
        this.movePlayerScript.setCanNotMove();
    }

    public bool getCanMove()
    {
        return this.movePlayerScript.getCanMove();
    }

    public void activeButtonA()
    {
        this.movePlayerScript.activeButtonA();
    }

    public void desactiveButtonA()
    {
        this.movePlayerScript.desactiveButtonA();
    }
}
