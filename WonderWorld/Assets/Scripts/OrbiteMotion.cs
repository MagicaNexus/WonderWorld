using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbiteMotion : MonoBehaviour {

	public Transform OrbitPivot;   // The transform that this object will orbit around
    public float OrbitSpeed = 100f;
     
     // Update is called once per frame
     void Update () {
         this.transform.RotateAround(OrbitPivot.position, Vector3.up, OrbitSpeed * Time.deltaTime);
     }
}
