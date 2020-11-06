using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health = 100f;
    [SerializeField] private GameObject deathEffect;
    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
            DeathVFX();
        }
    }

    public void DeathVFX()
    {
        if (!deathEffect)
        {
            return;
        }
        else
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
    }
}
