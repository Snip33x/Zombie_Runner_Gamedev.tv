using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] int damage = 25;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject hitEffect; //gameobject because we want to destroy it later on
    [SerializeField] Ammo ammoSlot;
    [SerializeField] float timeBetweenShoots = 0.5f;
    bool canShoot = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            StartCoroutine(Shoot());  
        }
    }

    IEnumerator Shoot()
    {
        canShoot = false;
        if (ammoSlot.GetCurrentAmmo() > 0)
        {
            PlayMuzzleFlash();
            ProcessRaycast();
            ammoSlot.ReduceAmmo();
        }
        yield return new WaitForSeconds(timeBetweenShoots);
        canShoot = true;
    }

    private void PlayMuzzleFlash()
    {
        muzzleFlash.Play();
    }

    private void ProcessRaycast()
    {
        RaycastHit hit;
        //out is stroing information about our raycasthit
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range)) 
        {

            Debug.Log(hit.collider);
            //TODO: add some hit effect for viual players
            CreateHitImpact(hit);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            //call a method on EnemyHealth that decreases the enemy's health
            if (target == null) return;
            target.TakeDamage(damage);
            CreateHitImpact(hit);
        }
        else
        {
            return;
        }
    }

    private void CreateHitImpact(RaycastHit hit)
    {
        GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, 0.1f);
    }
}
