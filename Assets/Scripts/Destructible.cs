using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    [SerializeField] int hitPoints = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.transform.tag == "Bullet")
        {
            Destroy(other.gameObject);
            hitPoints--;
            if(hitPoints == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
