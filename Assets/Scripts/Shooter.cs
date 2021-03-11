using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform bulletSpawn;
    [SerializeField] GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
        }
    }
}
