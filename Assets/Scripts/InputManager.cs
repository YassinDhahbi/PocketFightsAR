using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick joystickInputSource;

    [SerializeField]
    private float speedModifer;

    [SerializeField]
    private Rigidbody characterController;

    [SerializeField]
    private Animator playerAnimator;

    private bool canMove = true;

    private void MoveCharacter()
    {
        // Get the movement direction from the joystick input
        Vector3 movementDirection = new Vector3(joystickInputSource.Horizontal, 0f, joystickInputSource.Vertical);
        // If the movement direction is not zero, rotate the character towards the movement direction
        if (movementDirection.magnitude > 0)
        {
            characterController.transform.rotation = Quaternion.LookRotation(movementDirection, Vector3.up);
        }
        characterController.velocity = (movementDirection.normalized * speedModifer * Time.deltaTime);
        playerAnimator.SetFloat("speed", Mathf.Lerp(movementDirection.normalized.magnitude, 1, Time.deltaTime));
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            MoveCharacter();
        }
    }

    public void CanMoveSetter(bool state)
    {
        canMove = state;
    }

    // This is a coroutine that starts whenever the player attacks
    private IEnumerator MovementToggle()
    {
        StopCoroutine(MovementToggle());
        canMove = false;
        yield return new WaitForSeconds(1f);
        canMove = true;
    }

    public void MoveToggle()
    {
        StartCoroutine(MovementToggle());
    }
}