using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Controllers;

namespace UdemyProject3D.Movements
{
    public class VerticalMover : MonoBehaviour
    {
        EnemyController _enemyController;
        float _moveSpeed;
        public VerticalMover(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _moveSpeed = enemyController.MoveSpeed;
        }

        public void VerticalMove(float vertical = 1)
        {
            _enemyController.transform.Translate(Vector3.back * Time.deltaTime * _moveSpeed * vertical);
        }
    }

}
