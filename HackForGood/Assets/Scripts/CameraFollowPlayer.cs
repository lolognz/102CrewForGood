using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour {

    public Transform personaje;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(personaje.position.x, personaje.position.y, transform.position.z);
    }
}
