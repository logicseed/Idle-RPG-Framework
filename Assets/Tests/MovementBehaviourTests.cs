using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviourTests : MonoBehaviour
{
    public GameObject seekTarget;
    public GameObject avoidTarget;
    public GameObject avoidTarget2;
    public GameObject avoidTarget3;
    private AbstractMovementBehaviour movementBehaviour;
    private MovementController controller;
    public float seekRadius;
    public float avoidRadius;
    public float maxSpeed;

    // Use this for initialization
    void Awake ()
    {
        controller = gameObject.GetComponent<MovementController>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (movementBehaviour == null)
        {

            movementBehaviour = new IdleMovementBehaviour();
            movementBehaviour = new SeekMovementBehaviour(movementBehaviour, gameObject, seekTarget, seekRadius);
            movementBehaviour = new AvoidMovementBehaviour(movementBehaviour, gameObject, avoidTarget, avoidRadius);
            movementBehaviour = new AvoidMovementBehaviour(movementBehaviour, gameObject, avoidTarget2, avoidRadius);
            movementBehaviour = new AvoidMovementBehaviour(movementBehaviour, gameObject, avoidTarget3, avoidRadius);
        }
        var newPosition = movementBehaviour.Steering().normalized * controller.maxSpeed;
        transform.Translate(newPosition);
    }
}
