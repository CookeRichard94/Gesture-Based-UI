using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int damaged;

    public GameObject gameOverText;

    Lives lives;

    void Start()
    {
        gameOverText.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Heart"))
        {
            Lives.livesAmount += 1;
            
        }
    }

    public void Damage(int damaged)
    {
        Lives.livesAmount -= damaged;
    }

}
