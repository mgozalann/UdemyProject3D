using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject3D.Abstracts.Controllers
{
    public abstract class MyCharacterController : MonoBehaviour
    {
        [SerializeField] protected float _moveSpeed = 10f;
        [SerializeField] float _moveBoundary = 4.6f;

        public float MoveSpeed => _moveSpeed;
        public float MoveBoundary => _moveBoundary;

    }

}

