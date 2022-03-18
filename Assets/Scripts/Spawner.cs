using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform shootPoint; //����� �������� 
    [SerializeField] private Bullet bullettemplate; //������
   
    [SerializeField] private float delayBetweenShoots; //����� ����� ����������
    private float timeAfterShoot; //������� ��� ������������ ������� ���������

    private void Update()
    {
        timeAfterShoot += Time.deltaTime; //���������� �������� 
        if (timeAfterShoot > delayBetweenShoots)
         {
            Shoot();
            timeAfterShoot = 0;
        }     
    }
    //�������� �����������
    private void Shoot()
    {
        Instantiate(bullettemplate, shootPoint.position, Quaternion.identity);

    }


}

