using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform shootPoint; //точка создани€ 
    [SerializeField] private Bullet bullettemplate; //шаблон
   
    [SerializeField] private float delayBetweenShoots; //врем€ между выстрелами
    private float timeAfterShoot; //счетчик дл€ отслеживани€ частоты выстрелов

    private void Update()
    {
        timeAfterShoot += Time.deltaTime; //увеличени€ счетчика 
        if (timeAfterShoot > delayBetweenShoots)
         {
            Shoot();
            timeAfterShoot = 0;
        }     
    }
    //—оздани€ объектаѕули
    private void Shoot()
    {
        Instantiate(bullettemplate, shootPoint.position, Quaternion.identity);

    }


}

