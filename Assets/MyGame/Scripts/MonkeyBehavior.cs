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
        Appearing();

        InvokeRepeating("Appearing", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();

        if(Score >= 10)
        {
            WinText.enabled = true;
            CancelInvoke();
        }
        
    }

    public void Appearing ()
    {
        var positionNew = new Vector2(Random.Range(-6.5f,6.4f), Random.Range(-3.4f,2.5f));
        Instantiate(monkey,positionNew, Quaternion.identity);
        //monkey.transform.position = positionNew;
        monkiSound.Play();
    }

}
