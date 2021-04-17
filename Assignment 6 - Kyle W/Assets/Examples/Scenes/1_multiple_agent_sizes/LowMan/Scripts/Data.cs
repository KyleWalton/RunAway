using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public int lives;
    //public int score;

    //public Text Score;
    public Text Lives;

    private void Start()
    {
        lives = 3;
        Lives.text = "" + lives;
    }
}
