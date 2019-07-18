using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour {

    private Vector3 moveDirection = Vector3.zero;

    void Start () {
		
	}

	void Update () {
        Quaternion eulerRot = Quaternion.Euler(Input.GetAxis("Mouse X") * 100, Input.GetAxis("Mouse Y") * 100, 0.0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, eulerRot, Time.deltaTime * 10);

        //moveDirection = new Vector3(Input.GetAxis("Mouse X")*2, Input.GetAxis("Mouse Y")*2, 0);
        //this.transform.Rotate(moveDirection);
        //this.transform.eulerAngles = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        Debug.Log(moveDirection);
        if (Input.GetAxis("Right Trigger") > 0.3f)
        {
            Debug.Log("Pulsado");
            this.gameObject.GetComponent<Material>().color = this.changeColor();
        }

        if (Input.GetButtonDown("X Button"))
            Debug.Log("Has pulsado X");

        if (Input.GetButtonDown("A Button"))
            Debug.Log("Has pulsado A");

        if (Input.GetButtonDown("B Button"))
            Debug.Log("Has pulsado B");

        if (Input.GetButtonDown("Y Button"))
            Debug.Log("Has pulsado Y");

        if (Input.GetButtonDown("Start Button"))
            Debug.Log("Has pulsado Start");

        if (Input.GetButtonDown("Back Button"))
            Debug.Log("Has pulsado Back");

        if (Input.GetButtonDown("Right Bumper"))
            Debug.Log("Has pulsado RB");

        if (Input.GetButtonDown("Left Bumper"))
            Debug.Log("Has pulsado LB");

        if (Input.GetButtonDown("Left Stick Click"))
            Debug.Log("Has pulsado Left Click Stick");

        if (Input.GetButtonDown("Right Stick Click"))
            Debug.Log("Has pulsado Right Click Stick");
        
    }

    private Color changeColor()
    {
        return new Color(Random.Range(0 , 255), Random.Range(0, 255), Random.Range(0, 255), 0);
    }
}