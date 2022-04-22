using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject3D.Controllers
{
    public class FloorController : MonoBehaviour
    {
        Material _material;

        [Range(0.5f,2f)]
        [SerializeField]  float moveSpeed = 0.5f;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;
        }

        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * Time.deltaTime * moveSpeed;
        }
    }
}

