using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Bullet bullet;
    public float fireRate = 0.25f;
    public float nextFire = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextFire)
        {
            Shoot();
            nextFire = Time.time + fireRate;
        }//intervalo de balas
    }
    public void Shoot()
    {
    GameObject go = Instantiate(bullet.gameObject, transform.position, transform.rotation);  
    }
    
}
  