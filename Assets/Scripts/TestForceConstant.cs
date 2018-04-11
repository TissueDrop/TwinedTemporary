using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestForceConstant : MonoBehaviour
{
    public float fConstantForce;

    private Rigidbody2D RB;

    private GameObject OtherEntity;
	// Use this for initialization
	void Start ()
	{
	    RB = GetComponent<Rigidbody2D>();
	    if (name == "Player1")
	    {
	        OtherEntity = GameObject.Find("Player2");

        }
	    else
	    {
	        OtherEntity = GameObject.Find("Player1");
	    }
    }
	
	// Update is called once per frame
	void Update ()
	{
	    Vector2 TowardsOther = transform.position - OtherEntity.transform.position;
	    TowardsOther.Normalize();
	    RB.AddForce(TowardsOther * fConstantForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
