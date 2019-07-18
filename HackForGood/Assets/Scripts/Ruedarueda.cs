using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruedarueda : MonoBehaviour {

    private RectTransform rt;
    Vector3 rotationEuler;

    void Start()
    {
        this.rt = this.gameObject.GetComponent<RectTransform>();
    }

    void Update()
    {
        rotationEuler += Vector3.forward * 30 * Time.deltaTime; //increment 30 degrees every second
        transform.rotation = Quaternion.Euler(rotationEuler);
        //this.rt.Rotate(new Vector3(this.rt.rotation.x, this.rt.rotation.y, this.rt.rotation.z+1));
    }
}
