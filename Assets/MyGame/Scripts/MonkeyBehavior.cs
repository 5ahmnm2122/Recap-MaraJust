using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonkeyBehavior : MonoBehaviour
{

    public GameObject monkey;
    public Text ScoreText;
    public Text WinText;
    public int Score;
    public AudioSource bananaThrow;
    public AudioSource monkiSound;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        WinText.enabled = false;
        monkey.SetActive(false);
        Appearing();

        InvokeRepeating("Appearing", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();

        if(Score >= 10)
        {
            monkey.SetActive(false);
            WinText.enabled = true;
        }
        
    }

    public void Appearing ()
    {
        monkey.SetActive(false);
        var positionNew = new Vector2(Random.Range(-6.5f,6.4f), Random.Range(-3.4f,2.5f));
        monkey.transform.position = positionNew;
        monkey.SetActive(true);
        monkiSound.Play();
    }

    private void OnMouseDown()
    {
        bananaThrow.Play();
        Score += 1;
        Appearing();
    }

}
