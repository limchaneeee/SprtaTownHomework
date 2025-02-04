﻿using System;
using UnityEngine;

public class AimRotation : MonoBehaviour 
{

    [SerializeField] private SpriteRenderer characterRenderer;

    private Controller controller;

    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotationArm(direction);
    }

    private void RotationArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

    }
}