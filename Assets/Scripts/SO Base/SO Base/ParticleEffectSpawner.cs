using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Partcile Effect Spawner", menuName = "Game Events/Partcile Effect Spawner")]
public class ParticleEffectSpawner : ScriptableObject
{
    public GameObject particleEffect;
    [SerializeField]
    bool destroyable;
    
    [SerializeField]
    float duration;
    public void SpawnEffect(Transform t)
    {
        GameObject ParticleEffectHolder = Instantiate(particleEffect, t.position,Quaternion.identity);
        if (destroyable)
        {
            Destroy(ParticleEffectHolder, duration);
        }
        
    }


}
