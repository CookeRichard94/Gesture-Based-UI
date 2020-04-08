using UnityEngine;

public class Barrier : MonoBehaviour
{
    ColorChange color;

        void OnCollisionEnter2D(Collision2D col)
    {
        if(ColorChange.switchOn == true)
        {

        if(col.gameObject.tag.Equals("Player"))
            {
                ColorChange.switchOn = false;
                Destroy(gameObject);
            }

        }
    }
}