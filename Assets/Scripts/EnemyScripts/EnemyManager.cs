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

    private void Update()
    {
    }

    private void MovementBehaviour()
    {
        if (Vector3.Distance(transform.position, target.position) > minDistance)
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

    private void OnTriggerEnter(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
    }
}