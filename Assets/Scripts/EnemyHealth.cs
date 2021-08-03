using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    bool isDead = false;

    public bool IsDead()
    {
        return isDead;
    }    

    // create a public method which reduces hitpoints by the amount of damage

    public void TakeDamage(int damage)
    {
    // BroadcastMessage calls this method - this method can be used in many scripts , and when called here it will work in different scripts 
    //- ex. in Enemy Attack create method with this name, and let enemy also know that it was hit
        BroadcastMessage("OnDamageTaken"); 
        hitPoints -= damage;
        Debug.Log("Enemy have now " + hitPoints + " health");
        if (hitPoints <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
        //GetComponent<NavMeshAgent>().enabled = false;
        //GetComponent<EnemyAI>().enabled = false;
    }
}
