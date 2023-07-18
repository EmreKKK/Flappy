using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pipes : MonoBehaviour
{
    Spawner spawnerManager;
    Pipes pipe;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(10.0f, Random.Range(-1.6f, 1.6f), transform.position.z);
        spawnerManager = GameObject.Find("Spawner").GetComponent<Spawner>();
        pipe = GetComponent<Pipes>();


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -15f)
        {
            ScoreControl();
            Destroy(gameObject);
        }
        transform.Translate(-1.8f * Time.deltaTime, 0, 0);
    }

    public void ScoreControl()
    {
        if (pipe.transform.position.x < -5)
        {
            spawnerManager.IncreaseScore(1);
        }
    }

}
