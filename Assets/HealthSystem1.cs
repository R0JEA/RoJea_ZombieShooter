using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem1 : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    public bool dead = false;


    // Update is called once per frame
    void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            dead = true;
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);

        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);

        }
        if (dead == true)
        {
            Debug.Log("We are dead!");
            SceneManager.LoadScene("Lose scene"); 
        }
    }
    public void TakeDamage(int d)
    {
        life -= d;
    }
}
