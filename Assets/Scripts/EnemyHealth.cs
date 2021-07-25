using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

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
            Destroy(gameObject);
        }
    }
}
