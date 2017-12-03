using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
	int vel;

	// Use this for initialization
	void Start ()
	{
		vel = 20;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.right * Input.GetAxisRaw ("Horizontal") * vel * Time.deltaTime);
		if (transform.position.x < -20)
		{
			transform.position = new Vector3 (-20, transform.position.y, transform.position.z);
		}
		else if (transform.position.x > 20)
		{
			transform.position = new Vector3 (20, transform.position.y, transform.position.z);
		}
	}
}
