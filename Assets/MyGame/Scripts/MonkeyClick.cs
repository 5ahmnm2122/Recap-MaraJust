using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyClick : MonoBehaviour
{
    public MonkeyBehavior mb;
    public float time;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        mb = gameManager.GetComponent<MonkeyBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (mb.Score < 10)
        {
            mb.bananaThrow.Play();
            mb.Score += 1;
            mb.Appearing();
            Destroy(gameObject);
        }
    }
}
