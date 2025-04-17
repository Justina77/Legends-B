using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int startinghealth;
    [SerializeField] private float hitInterval = 0.5f;

    private float lastHitTime = 0;
    private int currenthealth;
    private Animator animator;
    public static bool isAlive = true;
    void Awake()
    {
        currenthealth = startinghealth;
        animator = GetComponent<Animator>();
        isAlive = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemyweapon") && isAlive && Time.time - lastHitTime > hitInterval)
        {
            TakeDamage(5);
        }
    }

    private void TakeDamage(int damage)
    {
        lastHitTime= Time.time;
        currenthealth -= damage;
        Debug.Log("Current health" + currenthealth);
        if (currenthealth > 0)
            animator.SetTrigger("Hit");
        else
        {
            isAlive = false;
            animator.SetTrigger("Death");
        }
    }

}
