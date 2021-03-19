using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    GameObject player;
    [SerializeField] float enemySpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.gameObject.transform.GetChild(0).GetComponent<MeshRenderer>())
        {
             transform.Translate((player.transform.position - transform.position).normalized.x * enemySpeed * Time.deltaTime, 0.0f, (player.transform.position - transform.position).normalized.z * enemySpeed * Time.deltaTime);
        }
        else
        {
            Destroy(this.gameObject);
        }
       
    }
}
