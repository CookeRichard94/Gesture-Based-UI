using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int livesAmount;
   // public Text livesText;
    Player player;
    public GameObject gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        //livesText = GetComponent<Text>();
        livesAmount = 1;
        //curScore = scoreAmount;
    }

    // Update is called once per frame
    void Update()
    {
      //  livesText.text = "X" + livesAmount;
        //scoreAmount = curScore;

        if (Lives.livesAmount <= 0)
            {
                gameOverText.SetActive(true);
                Time.timeScale = 0f;
            }
    }


}