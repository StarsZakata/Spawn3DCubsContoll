using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed;
	public float distance;

	private Vector3 positionShot;
	private Vector3 moveDirection;


	private void Start()
	{
		positionShot = FindObjectOfType<ShotPoint>().transform.position;
		moveDirection = Vector3.forward;
	}

	private void Update()
	{
		float dist = Vector3.Distance(positionShot, transform.position);
		if (dist > distance) {
			Destroy(gameObject);
		}
		transform.Translate(moveDirection * speed * Time.deltaTime);
	}
}
