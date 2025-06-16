using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnimationDemo
{
    /// <summary>
    /// YBotController is a placeholder class for controlling the YBot character in the animation demo.
    /// </summary>
    public class YBotController : MonoBehaviour
    {
        private static readonly int IS_WALKING = Animator.StringToHash("IsWalking");
        
        [SerializeField] private Animator animator;
        private static readonly int IS_RUNNING = Animator.StringToHash("IsRunning");

        private void Update()
        {
            ControllMovement();
        }

        private void ControllMovement()
        {
            animator.SetBool(IS_WALKING, Input.GetKey(KeyCode.W));
            animator.SetBool(IS_RUNNING, Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift));
        }
    }

}

