using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Movements;
using UdemyProject3D.Managers;

using System;

namespace UdemyProject3D.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        VerticalMover _verticalMover;

        [SerializeField] float _moveSpeed = 10f;
        float _curLifetime = 0f;
        [SerializeField] float _maxLifetime = 7f;

        public float MoveSpeed => _moveSpeed;

        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
        }
        private void Update()
        {
            _curLifetime += Time.deltaTime;
            if(_curLifetime > _maxLifetime)
            {
                _curLifetime = 0f;
                KillYourself();
            }
        }
        private void FixedUpdate()
        {
            _verticalMover.VerticalMove();
        }

        private void KillYourself()
        {
            EnemyManager.Instance.SetPool(this);
        }
    }
}
