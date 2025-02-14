using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHit : MonoBehaviour
{
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;

    private Rigidbody2D rb;

    private GameObject playerObj;
    private GameObject humanasObj;
    private Transform player;

    [SerializeField] public int killCount;

    // public AudioSource soundFx;
    // public AudioClip clip;

    void Start() {
        playerObj = GameObject.FindWithTag("PlayerTag");
        player = playerObj.GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {

      Vector3 direction = player.position - transform.position;
      float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
      angle = angle - 90;
      rb.rotation = angle;

      direction.Normalize();
      movement = direction;
    }

    void FixedUpdate() {
      moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction) {
      rb.MovePosition((Vector2)transform.position + (direction * maxSpeed * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            killed();
        } else if (collision.gameObject.tag == "PlayerTag")
        {
          // zombie hits the player
          humanasObj = GameObject.FindWithTag("PlayerTag");
          humanasObj.GetComponent<HealthSystem1>().TakeDamage(1); // remove 1 HP
          Destroy(gameObject);
          // play hit sound
          PlayHitSound.PlayerSound();
        }
        
    }

    public void killed() {
      killCount++;
      Debug.Log(killCount);
    }

}
