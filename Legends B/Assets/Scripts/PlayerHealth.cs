using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int startinghealth;
    [SerializeField] private float hitInterval = 0.5f;

    private float lastHitTime = 0;
    private int currenthealth;
    void Start()
    {
        currenthealth = startinghealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemyweapon") && Time.time - lastHitTime > hitInterval)
        {
            TakeDamage(5);
        }
    }

    private void TakeDamage(int damage)
    {
        lastHitTime= Time.time;
        currenthealth -= damage;
        Debug.Log("Current health" + currenthealth);
    }

    void Update()
    {
        
    }
}
