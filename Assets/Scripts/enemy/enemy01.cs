﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy01 : MonoBehaviour
{
    public float MoveSpeed;
    int hp;
    bool hit;



    void Start()
    {
        hp = 10;
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Hit!!!!" + col.gameObject.name);
        hit = true;
        hp -= 1;
    }
}
