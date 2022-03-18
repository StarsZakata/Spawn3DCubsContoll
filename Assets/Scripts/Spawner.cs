using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
	[Space(10)]
	[Range(1, 10)]
	[SerializeField] private float delayBetweenShoots;
	[Range(2, 10)]
	[SerializeField] private float speed;
	[Range(5, 25)]
	[SerializeField] private float distance;

	private float timeAfterShoot;
	private ShotPoint _shotPoint;

	private void Start()
    {
		_shotPoint = GetComponentInChildren<ShotPoint>();
	}
    private void Update()
	{
		timeAfterShoot += Time.deltaTime; //увеличения счетчика 
		if (timeAfterShoot > delayBetweenShoots)
		{
			_shotPoint.Shoot(speed, distance);
			timeAfterShoot = 0;
		}
	}
}


