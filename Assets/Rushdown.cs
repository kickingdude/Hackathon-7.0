using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rushdown : MonoBehaviour
{
    private Rigidbody2D rb;
    private Movement movement;
    private HitBox_Controller collide;
    public GameObject hitbox;
    //RushDown Vars
    public float dash = 40;
    public bool dashlock;
    private bool facing;

    public string up = "";
    public string down;
    public string left;
    public string right;
    public string Attack;
    public string Block;
    IEnumerator dashCheck()
    {
        rb.gravityScale = 0;
        dashlock = true;
        yield return new WaitForSeconds(0.15f);
        rb.gravityScale = 5;
        dashlock = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        collide = hitbox.GetComponent<HitBox_Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (up == "")
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
            movement = gameObject.GetComponent<Movement>();
            Debug.Log(up);
            up = movement.up;
            down = movement.down;
            left = movement.left;
            right = movement.right;
            Attack = movement.Attack;
            Block = movement.Block;
        }
        facing = movement.facing;
        if (Input.GetKeyDown(Block) && (Input.GetKey(right) || Input.GetKey(left)))
        {
            Dash();
        }
    }
    void Dash()
    {
        
            rb.gravityScale = 0f;
            if (facing == true)
            {
                rb.velocity += new Vector2(dash, 0.0f);
            }
            else if (facing == false)
            {

                rb.velocity += new Vector2(-dash, 0.0f);
            }
            StartCoroutine(dashCheck());
    }
    void NeutralAttack()
    {

        if (collide.hitcollide == true)
        {

        }
    }
    void DownAttack()
    {

    }
    void SideAttack()
    {

    }
}
