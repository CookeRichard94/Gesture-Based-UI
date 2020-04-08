using UnityEngine;

public class ColorChange : MonoBehaviour 
{
    private Renderer render;
    public static bool switchOn = false;

    [SerializeField]
    private Color changeColorTo = Color.white;

      void OnTriggerEnter2D(Collider2D col)
    {
        switchOn = true;
        render = GetComponent<Renderer>();
        render.material.color = changeColorTo;
       
    }
    
}