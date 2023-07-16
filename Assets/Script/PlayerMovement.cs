using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    [SerializeField] private VectorValue startingPosition;

    private Transform playerTransform;
    private Animator playerAnimator;
    private Vector3 currentVelocity = Vector3.zero;

    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator.SetFloat("moveX", 0);
        playerAnimator.SetFloat("moveY", -1);
        playerTransform = transform;
        playerTransform.position = startingPosition.initialValue;
    }

    private void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            playerAnimator.SetFloat("moveX", change.x);
            playerAnimator.SetFloat("moveY", change.y);
            playerAnimator.SetBool("moving", true);
        }
        else
        {
            playerAnimator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        change.Normalize();
        Vector3 targetPosition = playerTransform.position + change * speed * Time.fixedDeltaTime;
        myRigidbody.MovePosition(targetPosition);
    }
}
