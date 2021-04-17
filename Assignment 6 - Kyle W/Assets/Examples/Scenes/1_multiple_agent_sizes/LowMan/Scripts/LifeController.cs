using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{
    public Text Life;
    public bool timerHit = false;
    public DateTime lastLoss;
    public TimeSpan hitInterval;

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
        lifeDecrease(Life);

    }

    void lifeDecrease(Text life)
    {
        if (Int32.Parse(Life.text) != 0 && hitInterval.Seconds > 1)
        {
            int newLife = Int32.Parse(life.text) - 1;
            life.text = "" + newLife;
            lastLoss = DateTime.Now;
        }
        else if(Int32.Parse(Life.text) == 0)
        {
            Time.timeScale = 0;
        }
    }

    void Update()
    {
        hitInterval = DateTime.Now - lastLoss;
    }

    void Start()
    {
        lastLoss = DateTime.Now;
    }
}
