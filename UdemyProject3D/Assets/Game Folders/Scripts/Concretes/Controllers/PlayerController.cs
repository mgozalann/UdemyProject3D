using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Movements;
using UdemyProject3D.Inputs;
using UdemyProject3D.Managers;
using UnityEngine.InputSystem;
using System;

namespace UdemyProject3D.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float jumpForce;

        bool _isJump;
        bool _isDead;

        float _moveSpeed = 10f;
        float _moveBoundary = 4.6f;
        float _horizontal;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary;

        HorizontalMover _horizontalMover;
        JumpWithRigidbody _jumpWithRigidbody;
        InputReader _input; //interface almadýk

        private void Awake()
        {
            _horizontalMover = new HorizontalMover(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }



        private void FixedUpdate()
        {
            _horizontalMover.FixedTick(_horizontal);

            if (_isJump)
            {
                _jumpWithRigidbody.FixedTick(jumpForce);
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
            EnemyController _enemyController = other.GetComponent<EnemyController>();
            if (_enemyController != null)
            {
                _isDead = true;
                GameManager.Instance.StopGame();
            }

        }
    }
}

