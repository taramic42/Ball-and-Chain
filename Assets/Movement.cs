using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public string up;
    public string left;
    public string down;
    public string right;

    public float speed=0;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHort = 0;
        float moveVert = 0;

        if (Input.GetKey(up)) {
            moveVert += 1;
        }
        if (Input.GetKey(down))
        {
            moveVert -= 1;
        }
        if (Input.GetKey(right))
        {
            moveHort += 1;
        }
        if (Input.GetKey(left))
        {
            moveHort -= 1;
        }

        Vector2 movement = new Vector2(moveHort, moveVert);
        rb2d.AddForce(movement * speed);
        
    }
}
