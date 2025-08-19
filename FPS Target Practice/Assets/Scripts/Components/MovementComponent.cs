using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour 
{
    [SerializeField]
    private int speed;
    public IDirection direction;
    private void Awake()
    {
        direction = GetComponent<IDirection>();
    }
    private void Update()
    {
        Vector3 moveDir = direction.GetDirection();
        transform.position += speed * Time.deltaTime * moveDir;
    }
}
