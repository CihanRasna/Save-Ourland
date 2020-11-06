using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0f,5f)] [SerializeField] private float moveSpeed = 1f;
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector2.left * (Time.deltaTime * moveSpeed));
    }

    public void SetStartSpeed(float speed)
    {
        moveSpeed = speed;
    }
}
