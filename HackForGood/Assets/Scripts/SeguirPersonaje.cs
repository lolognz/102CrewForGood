using UnityEngine;
using System.Collections;

public class SeguirPersonaje : MonoBehaviour {
	private Transform personaje;
	public float separacion = 3f;
	public float limiteIzquierdo;
	public float limiteDerecho;

	void Start() {	
			this.personaje = GameObject.Find ("ChicaVestida").GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
			if (personaje.position.x <= limiteDerecho && personaje.position.x >= limiteIzquierdo){
				transform.position = new Vector3 (personaje.position.x+separacion,transform.position.y, transform.position.z);
			}
	}
}