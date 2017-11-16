using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTest : MonoBehaviour 
{
	public float yRotate = 5.0f;
	// Update is called once per frame
	void Update () 
	{
		yRotate += 5.0f;
		transform.eulerAngles = new Vector3 (0, yRotate, 0);
	}
}
