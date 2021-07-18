using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] int damage = 25;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range)) //out is stroing information about our raycasthit
        {
            Debug.Log(hit.collider);
            //TODO: add some hit effect for viual players
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            //call a method on EnemyHealth that decreases the enemy's health
            if (target == null) return;
            target.TakeDamage(damage);
        }
        else
        {
            return;
        }

    }
}
