using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementComponent))]
public class PlayerMovementController : MonoBehaviour, IDirection
{
    public Transform playerCamera;

    private MovementComponent movement;

    private void Awake()
    {
        movement = GetComponent<MovementComponent>();
        movement.direction = this;
    }

    public Vector3 GetDirection()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 forward = playerCamera.forward;
        Vector3 right = playerCamera.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 moveDir = forward * v + right * h;
        return moveDir.normalized;
    }
}
