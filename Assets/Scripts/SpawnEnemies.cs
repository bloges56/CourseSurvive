using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    GameObject spawnArea;
    [SerializeField] GameObject enemy;
    float time;
    Random random = new Random();
    // Start is called before the first frame update
    void Start()
    {
        spawnArea = GameObject.FindGameObjectWithTag("Spawn");
        time = Time.realtimeSinceStartup; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.realtimeSinceStartup - time >= 3)
        {
            float xSpawn = Random.Range(spawnArea.gameObject.transform.position.x - (spawnArea.gameObject.GetComponent<Collider>().bounds.size.x) / 2, spawnArea.gameObject.transform.position.x + (spawnArea.gameObject.GetComponent<Collider>().bounds.size.x) / 2);
            float zSpawn = Random.Range(spawnArea.gameObject.transform.position.z - (spawnArea.gameObject.GetComponent<Collider>().bounds.size.z) / 2, spawnArea.gameObject.transform.position.z + (spawnArea.gameObject.GetComponent<Collider>().bounds.size.z) / 2);
            Instantiate(enemy, new Vector3(xSpawn, 0.0f, zSpawn), Quaternion.identity);
            time = Time.realtimeSinceStartup;
        }
    }
}
