using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootDefault : MonoBehaviour
{
    public GameObject bullet;
    public float destroyBullet;
    public float bulletSpeed;
    private Rigidbody2D rb2d;

    public float nextFire;
    public float fireRate = 1;
    void Start()
    {

    }
    void Update()
    {
        nextFire += Time.deltaTime;

        if (playerCtrl.playerMoving == false && nextFire > fireRate)
        {
            GameObject m_bullet = Instantiate(bullet, transform.position, Quaternion.identity);
            rb2d = m_bullet.GetComponent<Rigidbody2D>();
            rb2d.AddForce(transform.up * bulletSpeed);
            Destroy(m_bullet, destroyBullet);
            nextFire = 0;
        }
    }
}
