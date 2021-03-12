using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 1.0f;
    Vector3 bulletDirection;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        bulletDirection = player.transform.forward;
        time = Time.realtimeSinceStartup;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup - time >= 2)
        {
            Destroy(this.gameObject);
        }
        transform.Translate(bulletDirection * bulletSpeed, Space.Self);
    }
}
