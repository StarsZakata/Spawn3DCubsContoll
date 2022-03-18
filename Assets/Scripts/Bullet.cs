using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	[SerializeField] private float speed;
	[SerializeField] private float distance;

	private Transform spwanPoint;
	private Vector3 moveDirection;
	
	private void Start()
	{
		spwanPoint = FindObjectOfType<Spawner>().transform;
		moveDirection = Vector3.forward;
	}

	private void Update()
	{
		float dist = Vector3.Distance(spwanPoint.position, transform.position);
		if (dist > distance) {
			Debug.Log(dist);
			Destroy(gameObject);
		}
		transform.Translate(moveDirection * speed * Time.deltaTime);
	}
}
