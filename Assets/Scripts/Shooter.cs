using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform bulletSpawn;
    [SerializeField] GameObject bullet;
    [SerializeField] float fireRate = 0.3f;
    float fireRateInterval;
    void Start()
    {
        fireRateInterval = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireRateInterval -= Time.deltaTime;
        if(Input.GetMouseButton(0) && fireRateInterval <= 0)
        {
            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            fireRateInterval = fireRate;
        }
    }
}
