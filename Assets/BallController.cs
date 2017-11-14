using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //(課題追記）得点テキスト
    private GameObject ScoreText;

    private GameObject SmallStar;

    // Use this for initialization

    private static int score;
    void Start()
    {
        this.ScoreText = GameObject.Find("ScoreText");
        score = 0;

        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }
    //(課題追記）衝突判定
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "SmallStar")
        {
            score = score + 10;
            Debug.Log(score);
            this.ScoreText.GetComponent<Text>().text = score + "点";
        }

        if (collision.gameObject.tag == "LageStar")
        {
            score = score + 20;
            Debug.Log(score);
            this.ScoreText.GetComponent<Text>().text = score + "点";
        }

        if (collision.gameObject.tag == "Smallcloud")
        {
            score = score + 15;
            Debug.Log(score);
            this.ScoreText.GetComponent<Text>().text = score + "点";
        }

        if (collision.gameObject.tag == "Lagecloud")
        {
            score = score + 25;
            Debug.Log(score);
            this.ScoreText.GetComponent<Text>().text = score + "点";
        }










    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        
     
    }
    
}
