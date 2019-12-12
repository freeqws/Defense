﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    Vector3 screenPosition;//将物体从世界坐标转换为屏幕坐标
    Vector3 mousePositionOnScreen;//获取到鼠标的屏幕坐标
    Vector3 mousePositionInWorld;//将鼠标的屏幕坐标转换为世界坐标
    public Vector3 targetPosition;

    public float MoveSpeed;

    public static bool playerMoving;

    void Start()
    {
        MoveSpeed = 10;
        targetPosition.y = transform.position.y;
    }
    void Update()
    {
        MouseFollow();

    }
    void MouseFollow()
    {       

        //获取鼠标在相机中（世界中）的位置，转换为屏幕坐标；
        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        //获取鼠标在场景中坐标
        mousePositionOnScreen = Input.mousePosition;
        //让场景中的Z=鼠标坐标的Z
        mousePositionOnScreen.z = screenPosition.z;
        //将相机中的坐标转化为世界坐标
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);
        //锁定y轴坐标
        Vector3 mousePosition_x = new Vector3(mousePositionInWorld.x, transform.position.y, transform.position.z);


        if (Input.GetMouseButton(0))
        {
            targetPosition = mousePosition_x;
        }
        //移动
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, MoveSpeed * Time.deltaTime);

        //判断角色是否在移动
        if (targetPosition.x != transform.position.x)
        {
            playerMoving = true;
        }
        else
        {
            playerMoving = false;
        }
                     
    }
}
