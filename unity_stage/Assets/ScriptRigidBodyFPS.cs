﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ScriptRigidBodyFPS : MonoBehaviour
{
    //Initialisation des variables
    public FixedJoystick MoveJoystick;
    public FixedJoystick MoveCamera;
    public FixedButton JumpButton;
    //public FixedTouchField TouchField;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = MoveJoystick.Direction;
        fps.JumpAxis = JumpButton.Pressed;
        fps.mouseLook.LookAxis = MoveCamera.Direction;
    }
}
