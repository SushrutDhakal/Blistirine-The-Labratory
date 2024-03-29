using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    [SerializeField] TextMeshProUGUI textBox;

    public float BulletForce = 1f;

    private bool canShoot = true;
    private int ammo = 30;

    // Update is called once per frame
    void Update()
    {
        textBox.text = ammo + "/30";

        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            ammo = ammo - 1;
            Shoot();
        }

        if (ammo == 0)
        {
            SoundManager.PlaySound("reload");
            StartCoroutine(reload());
        }
    }

    void Shoot()
    {
        SoundManager.PlaySound("shoot");
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * BulletForce, ForceMode2D.Impulse);
    }

    IEnumerator reload()
    {
        canShoot = false;        
        ammo = 30;
        textBox.text = ammo + "/30";
        yield return new WaitForSeconds(3);
        canShoot = true;
    }
}