using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    // create a public method which reduces hitpoints by the amount of damage

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        Debug.Log("Enemy have now " + hitPoints + " health");
        if (hitPoints <= 0)
        {
            Debug.Log("You dead ");
        }
    }

}
