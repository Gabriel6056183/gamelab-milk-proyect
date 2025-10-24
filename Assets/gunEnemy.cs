using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunEnemy : MonoBehaviour
{
public BulletEnemy BulletEnemy;
    public float fireRate = 0.40f;
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
    GameObject go = Instantiate(BulletEnemy.gameObject, transform.position, transform.rotation);  
   
    }
}
