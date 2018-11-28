using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour 
{

	public float speed = 0.5f; //how fast the object should rotate
		float cameraDistanceMax = 20f;
		float cameraDistanceMin = 5f;
		float cameraDistance = 10f;
		float scrollSpeed = 0.5f;
   
   Vector3 centerPos, targetPos, refPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Vector3.up * Time.deltaTime);
		
		 if(Input.GetMouseButtonDown(0))
      {
         centerPos = Input.mousePosition;
      }
      
      if(Input.GetMouseButton(0))
      {
         targetPos = Input.mousePosition;
      }
      centerPos = Vector3.SmoothDamp(centerPos,targetPos,ref refPos, 0.5f);
      Vector3 targetRotate = new Vector3(targetPos.y - centerPos.y, -(targetPos.x - centerPos.x), targetPos.z - centerPos.z);
      transform.Rotate(targetRotate * Time.deltaTime * speed,Space.World);
	  
	  cameraDistance += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
		cameraDistance = Mathf.Clamp(cameraDistance, cameraDistanceMin, cameraDistanceMax);
 
		
		
		
	}
}
