using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private Transform target;

    [SerializeField]
    private float lerpSpeed, minDistance;

    [SerializeField]
    private HealthManager healthManager;

    public bool canAttack;

    private void MovementBehaviour()
    {
        if (Vector3.Distance(transform.position, target.position) > minDistance && healthManager.isDead == false)
        {
            // calculate velocity of the rigidbody
            float velocity = rb.velocity.normalized.magnitude;

            // set the "speedh" float parameter in the animator
            animator.SetFloat("speedh", velocity);

            // lerp the position of the rigidbody towards the target
            Vector3 targetposition = new Vector3(target.position.x, rb.position.y, target.position.z);
            rb.position = Vector3.Lerp(rb.position, targetposition, Time.deltaTime * lerpSpeed);

            // make the rigidbody look at the target
            rb.rotation = Quaternion.LookRotation(targetposition - rb.position);
        }
        else
        {
            animator.SetFloat("speedh", 0);
        }
    }

    private void FixedUpdate()
    {
        MovementBehaviour();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out TagScript tagger) && tagger.tagValue == Tag.Player && !healthManager.isDead)
        {
            canAttack = true;
            animator.SetTrigger("attack");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out TagScript tagger) && tagger.tagValue == Tag.Player && !healthManager.isDead)
        {
            canAttack = false;
        }
    }
}