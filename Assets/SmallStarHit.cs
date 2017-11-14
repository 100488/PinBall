using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SmallStarHit : MonoBehaviour
{

    private GameObject ScoreText;
    private static int score;


    // Use this for initialization
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
        score = 0;

    }

    // Update is called once per frame

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Bdall")
        {
            score = score + 10;
        Debug.Log(score);
        this.ScoreText.GetComponent<Text>().text = score + "点";
            }
    }
    void Update()
    {


    }
}