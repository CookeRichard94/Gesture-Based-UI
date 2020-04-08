using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;

public class VoiceRecognition : MonoBehaviour
{
    public string[] keywords = new string[] { "up", "down", "left", "right", "stop", "start", "pause", "quit", "menu" };
    public ConfidenceLevel confidence = ConfidenceLevel.Medium;
    public GameObject pauseText;
    public float speed = 0.05f;

    //public TMPro results;
    public Rigidbody2D target;

    protected PhraseRecognizer recognizer;
    protected string word = "stop";

    private void Start()
    {
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
        //results.text = "You said: <b>" + word + "</b>";
    }

    private void Update()
    {
        var x = target.transform.position.x;
        var y = target.transform.position.y;

        switch (word)
        {
            case "up":
                y += speed;
                speed = 0.025f;
                break;
            case "down":
                y -= speed;
                speed = 0.025f;
                break;
            case "left":
                x -= speed;
                speed = 0.025f;
                break;
            case "right":
                x += speed;
                speed = 0.025f;
                break;
            case "stop":
                speed = 0;
                break;
            case "pause":
                Time.timeScale = 0f;
                pauseText.SetActive(true);
                break;
            case "play":
                Time.timeScale = 1f;
                pauseText.SetActive(false);
                break;
            case "quit":
                Application.Quit();
                break;
            case "menu":
                SceneManager.LoadScene(0);
                break;
        }

        target.transform.position = new Vector3(x, y, 0);
    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}