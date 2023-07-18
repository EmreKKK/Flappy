using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject pipes;
    public Text textScore;
    int score = 0;
    void Start()
    {
        InvokeRepeating("PipeSpawner", 0.0f, 3.0f);
        textScore.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PipeSpawner()
    {
        GameObject pipe = Instantiate(pipes);
    }

     public void IncreaseScore(int value)
    {
        score += value;
        textScore.text = score.ToString();

    }

}
