using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    //Movement
    [SerializeField] float playerSpeed;

    // Attack
    [SerializeField] Transform attackPoint;
    [SerializeField] float attackRange;
    [SerializeField] LayerMask enemyLayers;

    [Header("Events")]
    public UnityEvent OnAttackEvent;
    [Space]


    // Dash
    [SerializeField] float dashSpeed;
    [SerializeField] float dashDistance;
    [SerializeField] float timer;
    [SerializeField] float timerTime;

    //Jump
    [SerializeField] float JumpForce;
    [SerializeField] float lineLength;
    [SerializeField] float offset;
    [SerializeField] bool OnGround;
    [SerializeField] bool DoubleJump;

    //Stats
    [SerializeField] int health = 5;

    [Header("Events")]
    [Space]

    public UnityEvent OnHitEvent;

    [Space]
    public UnityEvent OnDieEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(playerSpeed * Input.GetAxisRaw("Horizontal"), GetComponent<Rigidbody2D>().velocity.y);
        //attack
        if (Input.GetKeyDown(KeyCode.Z))
        {
            OnAttack();
            Debug.Log("Attack");
        }
        //strong attack
        if (Input.GetKeyDown(KeyCode.X))
        {
            OnStrongAttack();
            Debug.Log("AttackStrong");
        }
        //dash
        timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.C))
        {
            Dash();
            Debug.Log("Dash");
        }
        //jump
        Vector2 origin = new Vector2(transform.position.x, transform.position.y - offset);
        Vector2 target = new Vector2(transform.position.x, transform.position.y - offset - lineLength);
        Debug.DrawLine(origin, target, Color.black);
        OnGround = Physics2D.Raycast(origin, Vector2.down, lineLength);
        if (OnGround)
        {
            DoubleJump = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnGround)
            {
                Jump();
                Debug.Log("Jump");
            }
            else if (!DoubleJump)
            {
                Jump();
                DoubleJump = true;
                Debug.Log("DoubleJump");
            }
        }
        //death
        if (health <= 0)
        {
            DIE();
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }

    void OnAttack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        OnAttackEvent.Invoke();

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<PlayerStats>().TakeDamage(1);
            Debug.Log("hitted");
        }

    }

    void OnStrongAttack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        OnAttackEvent.Invoke();

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<PlayerStats>().TakeDamage(1);
            enemy.GetComponent<KnockBack>().KnockBackEffect();
            Debug.Log("knockback hitted");
        }

    }

    void Dash()
    {

        if (timer <= 0)
        {
            transform.position = transform.position + new Vector3(Input.GetAxisRaw("Horizontal") * dashDistance, 0, 0);


            timer = timerTime;
        }
        else GetComponent<Rigidbody2D>().gravityScale = 1;

    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,
         JumpForce);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();

        if (damageDealer != null)
        {
            TakeDamage(damageDealer.GetDamage());
            damageDealer.Hit();
        }
    }
    public void TakeDamage(int Damage)
    {
        OnHitEvent.Invoke();
        health -= Damage;

        if (health <= 0)
        {
            DIE();
        }
    }

    public void DIE()
    {
        OnDieEvent.Invoke();
        gameObject.SetActive(false);
    }

    public int GetHealth()
    {
        return health;
    }
}

