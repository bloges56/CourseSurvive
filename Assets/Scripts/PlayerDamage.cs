using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] public int hitPoints = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy"){
            Debug.Log("Enemy Attack");
            hitPoints--;
            Destroy(other.gameObject);
            if(hitPoints == 0){
                Destroy(this.gameObject);
            }
        }
    }
}
