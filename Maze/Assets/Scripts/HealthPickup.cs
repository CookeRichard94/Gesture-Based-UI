using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
  // Player player;
       // public int healthPickup = 1;

        

        void OnTriggerEnter2D(Collider2D collider)
        {
            Lives.livesAmount += 1;
            Destroy(gameObject);
        }
}
