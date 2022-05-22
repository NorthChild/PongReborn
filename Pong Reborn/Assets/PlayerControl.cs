using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Start is called before the first frame update

    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;

    float speed = 2.5f;

    //private Rigidbody2D rb;
    private Rigidbody2D rb;// = GetComponent<Rigidbody2D>();


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); //When this object is loaded get the component Rigidbody2D in this gameobject and store it in rb2d
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKey(moveUp))
        {
            rb.AddForce(Vector2.up * speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rb.AddForce(Vector2.down * speed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
