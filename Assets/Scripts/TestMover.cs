using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMover : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    private Rigidbody2D RB;

    public float Thrust;

	// Use this for initialization
	void Start ()
	{
	    RB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKey(right))
	    {
            RB.AddForce(Vector2.right * Thrust);
	    }
	    if (Input.GetKey(left))
	    {
            RB.AddForce(Vector2.left * Thrust);
	    }
	    if (Input.GetKey(up))
	    {
            RB.AddForce(Vector2.up * Thrust);
	    }
	    if (Input.GetKey(down))
	    {
            RB.AddForce(Vector2.down * Thrust);
	    }

	}
}
