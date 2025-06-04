using UnityEngine;

public class creardiscodesierraderecha : MonoBehaviour
{
    public GameObject prefabEnemy;
    public GameObject prefabsPuas;
    private Transform comTransform;

    public float timeTiCreate = 5;
    public float currentTimetuCreate;

    public float timeTiCreate1 = 5;
    public float currentTimetuCreate1;

    public float timeTiCreate2 = 5;
    public float currentTimetuCreate2;

    public float timeTiCreate3 = 5;
    public float currentTimetuCreate3;

    public float timeTiCreate4 = 5;
    public float currentTimetuCreate4;

    public float TimeTiCreatepua = 16;
    public float currentTimetuCreatepua;

    public float TimeTiCreatepua2 = 20;
    public float currentTimetuCreatepua2;

    public float TimeTiCreatepua3 = 24;
    public float currentTimetuCreatepua3;

    public float TimeTiCreatepua4 = 28;
    public float currentTimetuCreatepua4;

    public Transform spawner1;
    public Transform spawner2;
    public Transform spawner3;
    public Transform spawner4;
    public Transform spawner5;
    public Transform spawnerpuas1;
    public Transform spawnerpuas2;
    public Transform spawnerpuas3;
    public Transform spawnerpuas4;

    private void Update()
    {
        currentTimetuCreate = currentTimetuCreate + Time.deltaTime;
        if (currentTimetuCreate >= timeTiCreate)
        {
            ShootBullet1();

            currentTimetuCreate = 0;
        }
        currentTimetuCreate1 = currentTimetuCreate1 + Time.deltaTime;
        if (currentTimetuCreate1 >= timeTiCreate1)
        {
            ShootBullet2();

            currentTimetuCreate1 = 0;
        }
        currentTimetuCreate2 = currentTimetuCreate2 + Time.deltaTime;
        if (currentTimetuCreate2 >= timeTiCreate2)
        {
            ShootBullet3();

            currentTimetuCreate2 = 0;
        }
        currentTimetuCreate3 = currentTimetuCreate3 + Time.deltaTime;
        if (currentTimetuCreate3 >= timeTiCreate3)
        {
            ShootBullet4();

            currentTimetuCreate3 = 0;
        }
        currentTimetuCreate4 = currentTimetuCreate4 + Time.deltaTime;
        if (currentTimetuCreate4 >= timeTiCreate4)
        {
            ShootBullet5();

            currentTimetuCreate4 = 0;
        }

        TimeTiCreatepua = TimeTiCreatepua + Time.deltaTime;
        if (TimeTiCreatepua>= currentTimetuCreatepua) {
            CrearPuas1();
           TimeTiCreatepua = 0;
        }

        TimeTiCreatepua2 = TimeTiCreatepua2 + Time.deltaTime;
        if (TimeTiCreatepua2 >= currentTimetuCreatepua2)
        {
            CrearPuas2();
            TimeTiCreatepua2 = 0;
        }

        TimeTiCreatepua3 = TimeTiCreatepua3 + Time.deltaTime;
        if (TimeTiCreatepua3 >= currentTimetuCreatepua3)
        {
            CrearPuas3();
            TimeTiCreatepua3 = 0;
        }

        TimeTiCreatepua4 = TimeTiCreatepua4 + Time.deltaTime;
        if (TimeTiCreatepua4 >= currentTimetuCreatepua4)
        {
            CrearPuas4();
            TimeTiCreatepua4 = 0;
        }
    }
    private void ShootBullet1()
    {
        GameObject bullet = Instantiate(prefabEnemy);
        bullet.transform.position = spawner1.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void ShootBullet2()
    {
        GameObject bullet = Instantiate(prefabEnemy);
        bullet.transform.position = spawner2.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void ShootBullet3()
    {
        GameObject bullet = Instantiate(prefabEnemy);
        bullet.transform.position = spawner3.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void ShootBullet4()
    {
        GameObject bullet = Instantiate(prefabEnemy);
        bullet.transform.position = spawner4.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void ShootBullet5()
    {
        GameObject bullet = Instantiate(prefabEnemy);
        bullet.transform.position = spawner5.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void CrearPuas1() {
        GameObject puas = Instantiate(prefabsPuas);
        puas.transform.position = spawnerpuas1.position;
        puas.transform.rotation = transform.rotation;
    }
    private void CrearPuas2()
    {
        GameObject puas = Instantiate(prefabsPuas);
        puas.transform.position = spawnerpuas2.position;
        puas.transform.rotation = transform.rotation;

    }
    private void CrearPuas3()
    {
        GameObject puas = Instantiate(prefabsPuas);
        puas.transform.position = spawnerpuas3.position;
        puas.transform.rotation = transform.rotation;

    }
    private void CrearPuas4()
    {
        GameObject puas = Instantiate(prefabsPuas);
        puas.transform.position = spawnerpuas4.position;
        puas.transform.rotation = transform.rotation;

    }
}
