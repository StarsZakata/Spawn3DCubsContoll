using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPoint : MonoBehaviour
{
	[SerializeField] private Bullet bullettemplate;

	public void Shoot(float Speed, float Distance)
	{
		bullettemplate.speed = Speed;
		bullettemplate.distance = Distance;
		Instantiate(bullettemplate, transform.position, Quaternion.identity);
	}
}
