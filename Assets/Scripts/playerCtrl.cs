using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    Vector3 screenPosition;//将物体从世界坐标转换为屏幕坐标
    Vector3 mousePositionOnScreen;//获取到鼠标的屏幕坐标
    Vector3 mousePositionInWorld;//将鼠标的屏幕坐标转换为世界坐标

    public float MoveSpeed;
    float Step;

    Vector3 targetPosition;
    

    void Start()
    {
        MoveSpeed = 5.0f;
    }
    void Update()
    {
         MouseFollow();
    }
    void MouseFollow()
    {

        Step = MoveSpeed * Time.deltaTime;

        //获取鼠标在相机中（世界中）的位置，转换为屏幕坐标；
        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        //获取鼠标在场景中坐标
         mousePositionOnScreen = Input.mousePosition;
        //让场景中的Z=鼠标坐标的Z
        mousePositionOnScreen.z = screenPosition.z;
        //将相机中的坐标转化为世界坐标
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);


        //锁定y轴坐标
        targetPosition = new Vector3(mousePositionInWorld.x, transform.position.y, transform.position.z);
        //物体跟随鼠标移动
        transform.position = Vector3.MoveTowards(transform.position,  targetPosition,Step);


    }
}
