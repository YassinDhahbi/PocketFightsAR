using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    [SerializeField]
    private HealthManager targetHealthMan;

    [SerializeField]
    private float swordDamage;

    [SerializeField]
    private TagScript target;

    [SerializeField]
    private bool isPlayer;

    [SerializeField]
    private InputManager inputManager;

    [SerializeField]
    private EnemyManager enemyManager;

    [SerializeField]
    private ParticleSystem hitEffect;

    private void OnTriggerEnter(Collider other)
    {
        var correctTarget = other.TryGetComponent(out TagScript tagger) && tagger.tagValue == target.tagValue;
        if (correctTarget)
        {
            if (inputManager && inputManager.canAttack && isPlayer && targetHealthMan.isDead == false)
            {
                // Insert the hitting behaviour for the enemy
                targetHealthMan.LoseHp(swordDamage);
                hitEffect.transform.position = other.ClosestPoint(transform.position);
                hitEffect.Play();
            }
            if (enemyManager && enemyManager.canAttack && !isPlayer && !inputManager.isBlocking)
            {
                // Insert the hitting behaviour for the enemy
                targetHealthMan.LoseHp(swordDamage);
                hitEffect.transform.position = other.ClosestPoint(transform.position);
                hitEffect.Play();
            }
        }
    }
}