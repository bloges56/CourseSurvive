using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CourseSurvive
{
    public class PlayerDamage : MonoBehaviour
    {
        [SerializeField] public static int hitPoints = 3;
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
            if (other.gameObject.tag == "Enemy")
            {
                hitPoints--;
                Destroy(other.gameObject);
                if (hitPoints == 0)
                {
                    Destroy(this.gameObject.transform.GetChild(0).gameObject);
                }
            }
        }
    }
}

