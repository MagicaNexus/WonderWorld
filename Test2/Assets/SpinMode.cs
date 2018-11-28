using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpinMode : MonoBehaviour {

	public float spinValue = 90;
	public string s = "scene";
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * spinValue * Time.deltaTime);
	}

	public void flipspin(){
		spinValue = -spinValue;
	}

	public void changeScene()
	{
		SceneManager.LoadScene(s);
	}
}
