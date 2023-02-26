using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Character Vars
    private string player_tag;
    public int character;
    public bool getTurn;
    public float jump;
    public Rigidbody2D rb;
    public bool facing;
    public float speedcap;

    //Player Control Vars
    public string up;
    public string down;
    public string left;
    public string right;
    public string Attack;
    public string Block;
    // Start is called before the first frame update


    void Start()
    {
        player_tag = gameObject.tag;
        if (player_tag == "P1")
        {
            up = "w";
            down = "s";
            left = "a";
            right = "d";
            Attack = "z";
            Block = "x";
        }
        else
        {
            up = "u";
            down = "j";
            left = "h";
            right = "k";
            Attack = "n";
            Block = "m";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (getTurn)
        {
            if (Input.GetKey(left))
            {
                facing = false;
                if ((rb.velocity.x) >= -speedcap)
                {
                    rb.velocity += new Vector2(-1f, 0.0f);
                }
            }
            if (Input.GetKey(right))
            {
                facing = true;
                if ((rb.velocity.x) <= speedcap)
                {
                    rb.velocity += new Vector2(1f, 0.0f);
                }
            }
            if (Input.GetKeyDown(up))
            {
                rb.velocity = new Vector2(0.0f, jump);
            }
        }
    }

    public string Player()
    {
        return player_tag;
    }
}
