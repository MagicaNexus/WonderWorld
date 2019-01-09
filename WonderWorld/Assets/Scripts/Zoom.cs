using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zoom : MonoBehaviour {
	public Transform target;
	public float speed = 1;
    void Update ()
{
    float scroll = Input.GetAxis ("Mouse ScrollWheel");
    transform.LookAt (target);
    transform.Translate(0, 0, scroll * speed, Space.Self);
}
}