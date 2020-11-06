using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    private Transform _hand;
    private float randomSpawn = 2f;


    private void Start()
    {
        _hand = transform.GetChild(0);
    }
    

    public void Fire(float damage)
    {
        Instantiate(projectile, _hand.transform.position, Quaternion.identity);
    }
}