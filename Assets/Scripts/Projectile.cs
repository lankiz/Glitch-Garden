using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0,10)]
    [SerializeField] float projectileSpeed = 1f;
    [SerializeField] float damage = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //reduce health 
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();
        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
            
        }
    }
}
