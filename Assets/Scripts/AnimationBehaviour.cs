using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBehaviour : MonoBehaviour 
{
	/*
	 * Animation States:
	 * 0 : Idle Left
	 * 1 : Idle Right
     * 2 : Walk Left
     * 3 : Walk Right
	 */

	Animator anim;
    Vector2 vector;
	int state;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
        state = -1;
        anim.SetInteger("state", state);
        vector = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        animationMovement();
    }

    void animationMovement()
    {
        //If player WAS moving to the right, Idle right
        if (vector.x == this.transform.position.x
            && state == 3)
        {
            state = 1;
            anim.SetInteger("state", state);

            //Update current position
            vector = this.transform.position;
        }

        //If player WAS moving to the left, Idle left
        if (vector.x == this.transform.position.x
            && state == 2)
        {
            state = 0;
            anim.SetInteger("state", state);

            //Update current position
            vector = this.transform.position;
        }

        //If player is walking right
        if (vector.x < this.transform.position.x)
        {
            state = 3;
            anim.SetInteger("state", state);

            //Update current position
            vector = this.transform.position;
        }

        //If player is walking left
        if (vector.x > this.transform.position.x)
        {
            state = 2;
            anim.SetInteger("state", state);

            //Update current position
            vector = this.transform.position;
        }
    }
}
