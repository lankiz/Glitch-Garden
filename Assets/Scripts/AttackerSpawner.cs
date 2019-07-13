using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    
    [SerializeField] Attacker[] attackerPrefabArray;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    bool spawn = true;
    // Start is called before the first frame update
   

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            if (spawn)
            {
                SpawnAttacker();
            }
        }
    }
    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        var attackerIndex = UnityEngine.Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }
    private void Spawn(Attacker myAttacker)
    {

        Attacker newAttacker = Instantiate(myAttacker ,
            transform.position,
                transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    
}
