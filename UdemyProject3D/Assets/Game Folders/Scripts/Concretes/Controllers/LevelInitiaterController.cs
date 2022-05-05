using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.ScriptableObjects;
using UdemyProject3D.Managers;

namespace UdemyProject3D.Controllers
{
    public class LevelInitiaterController : MonoBehaviour
    {
        LevelDifficultyData _levelDifficultyData;

        private void Awake()
        {
            _levelDifficultyData = GameManager.Instance.LevelDifficultyData;
        }

        private void Start()
        {
            RenderSettings.skybox = _levelDifficultyData.SkyboxMaterial;
            Instantiate(_levelDifficultyData.FloorPrefab);
            Instantiate(_levelDifficultyData.SpawnersPrefab);
            EnemyManager.Instance.SetMoveSpeed(_levelDifficultyData.MoveSpeed);
        }
    }

}
