using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorManager : MonoBehaviour
{
    [SerializeField]
    private Animator playerAnimator;

    [SerializeField]
    private Rigidbody playerRigidbody;

    private void Update()
    {
        playerAnimator.SetFloat("x", playerAnimator.velocity.x);
        print(playerAnimator.velocity);
        playerAnimator.SetFloat("z", playerAnimator.velocity.y);
    }
}