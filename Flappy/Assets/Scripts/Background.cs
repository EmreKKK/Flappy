using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public SpriteRenderer spriteBack;

    public float x;


    private void Update()
    {
        transform.Translate(-x, 0, 0);
    }
}
