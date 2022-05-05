using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Movements;
using UdemyProject3D.Managers;
using UdemyProject3D.Abstracts.Controllers;
using UdemyProject3D.Abstracts.Movements;
using UdemyProject3D.Enums;


namespace UdemyProject3D.Controllers
{
    public class EnemyController : MonoBehaviour , IEntityController
    {
        IMover _mover;

        [SerializeField] EnemyEnum _enemyEnum;
        [SerializeField] float _moveSpeed = 10f;
        float _curLifetime = 0f;
        [SerializeField] float _maxLifetime = 7f;

        public EnemyEnum EnemyType => _enemyEnum;
        public float MoveSpeed => _moveSpeed;

        public float MoveBoundary { get; }

        private void Awake()
        {
            _mover = new VerticalMover(this);
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
            _mover.FixedTick(1);
        }

        private void KillYourself()
        {
            EnemyManager.Instance.SetPool(this);
        }

        public void SetMoveSpeed(float moveSpeed)
        {
            if (moveSpeed < _moveSpeed) return;
            _moveSpeed = moveSpeed;
        }
    }
}
