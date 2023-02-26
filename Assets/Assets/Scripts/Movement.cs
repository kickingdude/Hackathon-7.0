using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Movement : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600);
    //Character Vars
    private string player_tag;
    public int character;
    public static bool P1turn = true;
    public static bool P2turn = false;
    public float jump;
    private Rigidbody2D rb;
    public bool facing;
    public float speedcap;

    public string receivedstring;
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
        sp.Open();
        
        //Character();
        rb = gameObject.GetComponent<Rigidbody2D>();
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
        if (sp.IsOpen)
        {
            receivedstring = sp.ReadLine();
        
            if ((player_tag == "P1" && P1turn == true) || (player_tag == "P2" && P2turn == true))
            {
                if (receivedstring == left)
                {
                 facing = false;
                 if ((rb.velocity.x) >= -speedcap)
                 {
                     rb.velocity += new Vector2(-1f, 0.0f);
                 }
                }
                if (receivedstring == right)
                {
                    facing = true;
                    if ((rb.velocity.x) <= speedcap)
                    {
                        rb.velocity += new Vector2(1f, 0.0f);
                    }
                }
                if (receivedstring == up)
                {
                    rb.velocity = new Vector2(0.0f, jump);
                }
            }   
      } 
    }

    public string Player()
    {
        return player_tag;
    }
    /*
    void Character()
    {
        if (character == 1)
        {
            gameObject.AddComponent<Rushdown>();
        }
        else if (character == 2)
        {
            gameObject.AddComponent<Rizzard>();
        }
        else
        {
            gameObject.AddComponent<Knight>();
        }
    }
    */
}
