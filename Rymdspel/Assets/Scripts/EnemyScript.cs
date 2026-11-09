using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemyShips enemyShip;
    public SpriteRenderer enemyShipSR;
    public float enemyMoveSpeed;
    private Rigidbody2D enemyRb;
    
    public int EnemyHealth;

    void Awake()
    {
        enemyMoveSpeed = enemyShip.EnemyShipSpeed;
        enemyShipSR = GetComponent<SpriteRenderer>();
        enemyShipSR.sprite = enemyShip.EnemyShipSprite; 
        EnemyHealth = enemyShip.EnemyShipHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyShip != null)
        {
            enemyRb = GetComponent<Rigidbody2D>();
            enemyRb.linearVelocity = Vector2.down * enemyMoveSpeed;
        }
        if(EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
