using UnityEngine;
using TMPro;

public class Player : MonoBehaviour, IDamagable
{
    public TextMeshPro text;

    private float movement;
    private float moveSpeedAcceleration = 15f;
    private short maxHealth;
    private short currentHealth;

    public short MaxHealth { get => maxHealth; set => maxHealth = value; }
    public short CurrentHealth
    {
        get { return currentHealth; }
        set
        {
            currentHealth = value;
            if(currentHealth <= 0)
            {
                Die();
                currentHealth = 0;
            }
            UpdateHealth();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
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
        CurrentHealth -= (short)damage;
    }
    void UpdateHealth()
    {
        text.text = CurrentHealth.ToString() + " / " + MaxHealth.ToString();
    }
}
