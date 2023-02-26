using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rizzard : MonoBehaviour
{
    private Rigidbody2D rb;
    private Movement movement;
    public bool collide;
    private GameObject hitbox;
    //RushDown Vars
    private bool facing;
    public GameObject Hitbox_holder;

    public float MaxHitPoints = 20;
    public float health;
    public string up = "";
    public string down;
    public string left;
    public string right;
    public string A;
    public string B;

    // Start is called before the first frame update
    void Start()
    {
        hitbox = Instantiate(Hitbox_holder, new Vector2(transform.position.x + 1f, transform.position.y), transform.rotation);
        collide = hitbox.GetComponent<Hit_Box_Controller>().hitcollide;
        hitbox.SetActive(false);
        Hitbox_holder.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        hitbox.transform.position = new Vector2(transform.position.x + 1f, transform.position.y);
        if (up == "")
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
            movement = gameObject.GetComponent<Movement>();
            up = movement.up;
            down = movement.down;
            left = movement.left;
            right = movement.right;
        }
        facing = movement.facing;
        //Change all of these to elif
        /*
        if (Input.GetKeyDown(B))
        {
            Block();
        }
        if (Input.GetKeyDown(A) && (Input.GetKey(left) || Input.GetKey(right)))
        {
            SideAttack();
        }
        if (Input.GetKeyDown(A) && Input.GetKey(down))
        {
            DownAttack();
        }
        if (Input.GetKeyDown(A))
        {
            Debug.Log(collide);
            NeutralAttack();
            collide = hitbox.GetComponent<Hit_Box_Controller>().hitcollide;
            Debug.Log(collide);
        }
        if (collide == true)
        {
            hitbox.SetActive(false);
            collide = false;
        }
        */
    }
}
