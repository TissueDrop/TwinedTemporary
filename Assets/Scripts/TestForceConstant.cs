using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Playables;

public class TestForceConstant : MonoBehaviour
{
    public float fConstantForce;

    private Rigidbody2D RB;

    private GameObject OtherEntity;

    private Color cRayColor;

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
	    Vector2 TowardsOther = OtherEntity.transform.position - transform.position;
	    Vector2 AwayFromOther = -TowardsOther;
	    RaycastHit2D hit = Physics2D.Raycast(transform.position, TowardsOther.normalized, Vector3.Distance(transform.position, OtherEntity.transform.position));
	    Debug.DrawRay(transform.position, TowardsOther, cRayColor);
        if (hit.collider.gameObject.CompareTag("Player"))
        {
            cRayColor = Color.green;
	        RB.AddForce(AwayFromOther.normalized * fConstantForce);
        }
        else
        {
            cRayColor = Color.red;
        }
    }

    //RaycastHit2D hit = Physics2D.Raycast(goBulletStartPosition.transform.position, Vector2.right, fRayDistance);
    //Debug.DrawRay(goBulletStartPosition.transform.position, v3DebugRay, Color.red);

    //if (hit == true
    //&& (hit.collider.gameObject.CompareTag("Enemy") || hit.collider.gameObject.CompareTag("Wasp"))
    //&& !BeeManager.bFormationActive
    //&& Time.time > fNextShot
    //&& !sBeeCollision.bIsDead)
    //{
    //    Shoot();
    //}

    //private void OnCollisionEnter2D(Collision2D p_cOther)
    //{
    //    if (p_cOther.gameObject.CompareTag("Platform"))
    //    {
    //        b_isTouchingPlatform = true;
    //    }
    //}
}
