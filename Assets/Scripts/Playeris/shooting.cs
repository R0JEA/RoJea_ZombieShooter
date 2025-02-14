using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
   public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    bool canShoot = true;


    void Start()
    {
      StartCoroutine(ShootingDelay());
    }

    IEnumerator ShootingDelay()
    {
      
      while (true) {
         yield return new WaitForSeconds(0.5f); // wait for half a second then shoot
         canShoot = true;
      }
    }
    
    void Update()
    {   
      if (canShoot == true) {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump")) {
          Shoot();
          canShoot = false;
        }
      }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

}
