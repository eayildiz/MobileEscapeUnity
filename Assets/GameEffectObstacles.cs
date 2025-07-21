using UnityEngine;

public abstract class GameEffectObstacles : MonoBehaviour
{
    private string obstacleType;
    public string ObstacleType { get => obstacleType; set => obstacleType = value; }

    private int damageAmount;
    public int DamageAmount { get => damageAmount; set => damageAmount = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObstacleType = "Effect Obstacle";
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    public abstract void AssignObstacleType();
    public abstract void AssignDamageAmount();
}
