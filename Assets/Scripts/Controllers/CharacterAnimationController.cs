using System;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private readonly float magnituteThreshold = 2.0f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}

