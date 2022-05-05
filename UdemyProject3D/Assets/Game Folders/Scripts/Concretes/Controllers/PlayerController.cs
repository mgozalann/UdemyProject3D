using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Movements;
using UdemyProject3D.Inputs;
using UdemyProject3D.Managers;
using UnityEngine.InputSystem;
using System;
using UdemyProject3D.Abstracts.Controllers;
using UdemyProject3D.Abstracts.Movements;

namespace UdemyProject3D.Controllers
{
    public class PlayerController : MyCharacterController, IEntityController
    {
        [SerializeField] float jumpForce;

        bool _isJump;
        bool _isDead;
        
        float _horizontal;

        IMover _mover;
        IJump _jump;

        InputReader _input; //interface almadýk

        private void Awake()
        {
            _mover = new HorizontalMover(this);
            _jump = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }



        private void FixedUpdate()
        {
            _mover.FixedTick(_horizontal);

            if (_isJump)
            {
                _jump.FixedTick(jumpForce);
            }
            _isJump = false;
        }

        private void Update()
        {
            if (_isDead) return;
            _horizontal = _input.Horizontal;
            if (_input.IsJump)
            {
                _isJump = true;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
             IEntityController entityController= other.GetComponent<IEntityController>();
            if (entityController != null)
            {
                _isDead = true;
                GameManager.Instance.StopGame();
            }

        }
    }
}

