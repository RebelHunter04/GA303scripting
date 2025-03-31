using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;
    public int attackDamage;
    public float attackRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damageTaken)
    {
        Health -= damageTaken;
    }
    public void Die()
    {
        Health = 0;
    }
    
}
