using UnityEngine;

public class RedCircle : GameEffectObstacles
{
    public RedCircle()
    {
        AssignDamageAmount();
        AssignObstacleType();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IDamagable damagableCollider = collision.GetComponent<IDamagable>();
        if (damagableCollider is not null)
        {
            damagableCollider.ReceiveDamage(DamageAmount);
        }
        Destroy(gameObject);
    }

    public override void AssignObstacleType()
    {
        ObstacleType = "Red Circle";
    }
    public override void AssignDamageAmount()
    {
        DamageAmount = 30;
    }
}