using System.Collections;
using System.Collections.Generic;
using UdemyProject3D.Controllers;
using UnityEngine;

namespace UdemyProject3D.Movements
{
    public class JumpWithRigidbody : MonoBehaviour
    {
        Rigidbody _rb;
        public bool CanJump => _rb.velocity.y != 0f;

        public JumpWithRigidbody(PlayerController playerController)
        {
            _rb = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick(float jumpForce)
        {
            if (CanJump) return;

            _rb.velocity = Vector3.zero;
            _rb.AddForce(Vector3.up * Time.deltaTime * jumpForce);
        }
    }

}

