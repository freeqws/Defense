﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet01: MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Hit!!!!" + col.gameObject.name);
        Destroy(gameObject);
    }


}
