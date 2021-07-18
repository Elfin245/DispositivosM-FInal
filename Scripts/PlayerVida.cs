using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVida : MonoBehaviour
{
    public float vida, maxvida;
    public GameObject GO;
    void Start()
    {
        vida = maxvida;
        GO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (vida>maxvida)
        {
            vida = maxvida;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            vida -= collision.GetComponent<Enemy>().Daño;
            if (vida<=0)
            {
                Destroy(gameObject);
                GO.SetActive(true);
            }
        }
    }
}
