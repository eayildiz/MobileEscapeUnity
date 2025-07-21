using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{
    public float movement;
    private float moveSpeedAcceleration = 15f;

    private int health;

    public int Health { get => health; set => health = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
        if(health == 0)
        {
            Die();
        }
    }

    private void FixedUpdate()
    {
        transform.position += moveSpeedAcceleration * Time.fixedDeltaTime * new Vector3(movement, 0, 0);
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void ReceiveDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
}
