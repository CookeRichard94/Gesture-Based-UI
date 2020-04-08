using UnityEngine;

public class ScrollinBackground : MonoBehaviour
{

public float bgSpeed;
public Renderer bgRend;

void Update()
{
    bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
}


}