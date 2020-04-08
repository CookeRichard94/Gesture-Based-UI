using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    Key key;
    //public GameObject text;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(Key.keyGot == true)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Test");
        Key.keyGot = false;
        Debug.Log("Test");
        }
        
       // else if (col.tag == "Player")
      //  {
       //     text.SetActive(true);
       // }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Key.keyGot = false;
    }

    //void OnTriggerExit2D(Collider2D col)
   // {
    //    text.SetActive(false);
   // }
}
