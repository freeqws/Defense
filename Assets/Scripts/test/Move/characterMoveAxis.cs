using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMoveAxis: MonoBehaviour
{
    float HorizontalSpeed;
    float VerticalSpeed;
    public float MoveSpeed;
    void Start()
    {

    }

    void Update()
    {
        HorizontalSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
        VerticalSpeed = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(HorizontalSpeed, VerticalSpeed, 0);
    }

}

