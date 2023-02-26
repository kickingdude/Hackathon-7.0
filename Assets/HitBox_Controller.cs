using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox_Controller : MonoBehaviour
{
    public bool hitcollide;
    // Start is called before the first frame update
    void Start()
    {
        hitcollide = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "P1" || collision.collider.tag == "P2")
        {
            hitcollide = true;
        }
    }
}
