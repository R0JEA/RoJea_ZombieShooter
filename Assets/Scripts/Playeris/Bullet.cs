using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Bullet : MonoBehaviour
    
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
