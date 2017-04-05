using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviourTests : MonoBehaviour {

    public GameObject seekTarget;
    public GameObject avoidTarget;
    private AbstractMovementBehaviour movementBehaviour;
    private MovementController controller;

	// Use this for initialization
	void Start () {
        movementBehaviour = new IdleMovementBehaviour();
        movementBehaviour = new SeekMovementBehaviour(movementBehaviour, gameObject, seekTarget);
        movementBehaviour = new AvoidMovementBehaviour(movementBehaviour, gameObject, avoidTarget, 0.5f);
        controller = gameObject.GetComponent<MovementController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        var newPosition = movementBehaviour.Steering().normalized * controller.maxSpeed;
        transform.Translate(newPosition);
	}
}
