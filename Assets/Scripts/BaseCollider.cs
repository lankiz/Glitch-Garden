using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollider : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D otherCollider) {
        FindObjectOfType<LivesDisplay>().ReduceLives();
        Destroy(otherCollider.gameObject);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
