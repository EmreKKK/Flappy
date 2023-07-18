using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishes : MonoBehaviour
{
    public float fishSpeed=0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -10.0f)
        {
            transform.position = new Vector3(10.0f, Random.Range(-4.5f, 4.5f), transform.position.z);
        }

        transform.Translate(-fishSpeed * Time.deltaTime, 0, 0);
    }
}
