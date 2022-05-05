using System.Collections;
using System.Collections.Generic;
using UdemyProject3D.Controllers;
using UnityEngine;

namespace UdemyProject3D.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Create Difficulty/Create New", fileName = "Level Difficulty", order =1)]
    public class LevelDifficultyData : ScriptableObject
    {
        [SerializeField] FloorController _floorPrefab;
        [SerializeField] GameObject _spawnersPrefab;
        [SerializeField] Material _skyboxMaterial;
        [SerializeField] float _moveSpeed = 10f;

        public FloorController FloorPrefab => _floorPrefab;
        public GameObject SpawnersPrefab => _spawnersPrefab;
        public Material SkyboxMaterial => _skyboxMaterial;
        public float MoveSpeed => _moveSpeed;
    }

}
