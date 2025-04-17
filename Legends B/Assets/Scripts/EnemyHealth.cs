using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth;
    [SerializeField] private float hitInterval = 0.5f;

    private float lastHitTime = 0;
    private int currentHealth;
    private Animator animator;
    private bool isDead = false;

    public bool IsDead
    {
        get { return isDead; }
    }
    private void Awake()
    {
        currentHealth = startingHealth;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Playerweapon"))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        lastHitTime = Time.time;
        currentHealth -= damage;
        if (currentHealth > 0)
            animator.SetTrigger("hit");
        else
        {
            animator.SetTrigger("death");
            isDead = true;
        }
    }
}
