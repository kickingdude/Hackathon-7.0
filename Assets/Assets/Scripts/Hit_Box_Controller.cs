using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Box_Controller : MonoBehaviour
{
    public bool hitcollide = false;
    // Start is called before the first frame update
    void Start()
    {
        hitcollide = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "P1") || (collision.gameObject.tag == "P2"))
        {
            hitcollide = true;
        }
    }
}
