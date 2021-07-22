using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    //DeathHandler deathHandler;

    // create a public method which reduces hitpoints by the amount of damage



    public void TakeDamage(int damage)
    {
        hitPoints -= damage;
        Debug.Log("Enemy have now " + hitPoints + " health");
        if (hitPoints <= 0)
        {
            //deathHandler.HandleDeath();
            GetComponent<DeathHandler>().HandleDeath(); //we dont do variable of scrpit and above call because we would have to add getcomponent in start because of nullreferenceError in game - this is much faster way because we need only call 1 method
            Debug.Log("You dead ");
        }
    }

}
