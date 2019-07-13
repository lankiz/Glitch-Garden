using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject deathVFX;
    [SerializeField] float durationOfExplosion = 0.5f;

    [SerializeField] float health = 100f;
    // Start is called before the first frame update
    public void DealDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
            
        }
    }

    private void TriggerDeathVFX()
    {
       if (!deathVFX){ return; }
        GameObject explosion = Instantiate(deathVFX,
                transform.position, transform.rotation);
        Destroy(explosion, durationOfExplosion);
    }
}
