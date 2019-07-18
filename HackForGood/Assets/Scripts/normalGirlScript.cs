using UnityEngine;

public class normalGirlScript : MonoBehaviour {

    private Animator anim;

	void Start () {
        this.anim = this.gameObject.GetComponent<Animator>();
	}
	
    public void animarTeleport()
    {
        this.anim.SetBool("Teletransport", true);
    }
}
