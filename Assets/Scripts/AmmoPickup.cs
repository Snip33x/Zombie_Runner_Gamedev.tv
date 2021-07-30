using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Ammo Picked up");
            Destroy(gameObject);
        }
    }

    //private void OnCollisionEnter(Collision collision) //test
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("You've picked up some ammo");
    //        Destroy(gameObject);
    //    }
    //}
}
