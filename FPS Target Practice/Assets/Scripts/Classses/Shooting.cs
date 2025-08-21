using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private float range = 50f;
    private RaycastHit hit;
    public Camera playerCamera;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        if (Physics.Raycast(playerCamera.transform.position,playerCamera.transform.forward,out hit,range))
        {
            var target = hit.transform.GetComponent<IDamageable>();
            if (target != null)
            {
                target.TakeDamage();
            }
        }
    }
}
