using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
	int dirY;
	float velX, velY;

	// Use this for initialization
	void Start ()
	{
		dirY = -1;
		velX = 0f;
		velY = 30f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.right * velX * Time.deltaTime);
		transform.Translate (Vector3.up * dirY * velY * Time.deltaTime);
		if (transform.position.x <= -23 || transform.position.x >= 23)
		{
			velX *= -1;
		}
		if (transform.position.y >= 49)
		{
			dirY *= -1;
		}
		else if (transform.position.y <= -49)
		{
			dirY = -1;
			velX = 0f;
			velY = 30f;
			transform.position = new Vector3 (0, 0, 0);
		}
	}

	void OnTriggerEnter(Collider outro)
	{
		dirY *= -1;
		if (outro.name == "Jogador")
		{
			velX = (transform.position.x - outro.transform.position.x) * 5;
		}
	}
}
