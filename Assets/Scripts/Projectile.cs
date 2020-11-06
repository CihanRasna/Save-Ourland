using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 5f)] [SerializeField] private float moveSpeed = 2f;
    [Range(0f, 5f)] [SerializeField] private float rotateSpeed = 30f;
    [SerializeField] private float damage = 50f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.right * (Time.deltaTime * moveSpeed));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Health>();
        var enemy = other.GetComponent<Enemy>();
        if (enemy && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject , 3f);
        }
    }
}