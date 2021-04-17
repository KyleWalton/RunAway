using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public Text Score;

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
        increaseScore(Score);
        Destroy(this.gameObject);
        
    }

    void increaseScore(Text score)
    {
        int newScore = Int32.Parse(score.text) + 10;

        score.text = "" + newScore;
    }
}
