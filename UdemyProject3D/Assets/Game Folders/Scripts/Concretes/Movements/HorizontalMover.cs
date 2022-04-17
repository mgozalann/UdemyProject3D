using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Controllers;


namespace UdemyProject3D.Movements
{
    public class HorizontalMover : MonoBehaviour
    {
        PlayerController _playerController;
        float _moveBoundary;
        float _moveSpeed;

        public HorizontalMover(PlayerController playerController)
        {
            _playerController = playerController;
            _moveSpeed = playerController.MoveSpeed;
            _moveBoundary = playerController.MoveBoundary;
        }

        public void FixedTick(float horizontal)
        {
            if (horizontal == 0f) return;
            _playerController.transform.Translate(Vector3.right * horizontal * Time.deltaTime * _moveSpeed);
            float xBoundary = Mathf.Clamp(_playerController.transform.position.x, -_moveBoundary, _moveBoundary);
            _playerController.transform.position = new Vector3(xBoundary, _playerController.transform.position.y, _playerController.transform.position.z);
        }
    }

}
