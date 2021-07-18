using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVida : MonoBehaviour
{
    Enemy enemy;
    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon"))
        {
            enemy.vida -= 2f;
            if (enemy.vida<=0)
            {
                Destroy(gameObject);
            }
        }
    }
}
