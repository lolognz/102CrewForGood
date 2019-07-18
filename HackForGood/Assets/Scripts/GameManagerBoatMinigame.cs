using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerBoatMinigame : MonoBehaviour
{
    public GameObject boatPlayer;
    public GameObject boatPlayer2;
    public GameObject boatPlayer3;

    private moveBoat movePlayerScript;
    private moveBoat movePlayerScript2;
    private moveBoat movePlayerScript3;
    private bool blockDialogue = false;

    void Start()
    {
        this.movePlayerScript = this.boatPlayer.GetComponent<moveBoat>();
        this.movePlayerScript2 = this.boatPlayer2.GetComponent<moveBoat>();
        this.movePlayerScript3 = this.boatPlayer3.GetComponent<moveBoat>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetButtonDown("Back Button")))
        {
            Debug.Log("Saliendo...");
            Application.Quit();
        }
    }


    public void setCanMove()
    {
        this.movePlayerScript.setCanMove();
        this.movePlayerScript2.setCanMove();
        this.movePlayerScript3.setCanMove();
    }

    public void setCanNotMove()
    {
        this.movePlayerScript.setCanNotMove();
        this.movePlayerScript2.setCanMove();
        this.movePlayerScript3.setCanMove();
    }

    public void loadSceneIndias(){
        SceneManager.LoadScene("scene5");
    }

    public void loadScenePerdido(){
        SceneManager.LoadScene("BoatMinigame");
    }
}

