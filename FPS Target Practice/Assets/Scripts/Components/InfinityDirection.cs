using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityDirection : MonoBehaviour, IDirection
{
    private float time;
    private MovementComponent movement;
    private float movementScale = 5f;

    private void Awake()
    {
        movement = GetComponent<MovementComponent>();
    }

    public Vector3 GetDirection()
    {
        time += Time.deltaTime * movement.speed;

        float x = Mathf.Cos(time);
        float y = Mathf.Sin(2 * time) / 2f;

        Vector3 dir = new Vector3(x, y, 0).normalized;
        return dir * movementScale;

    }
}
