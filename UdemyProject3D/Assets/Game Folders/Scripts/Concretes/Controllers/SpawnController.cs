using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Managers;

namespace UdemyProject3D.Controllers
{
    public class SpawnController : MonoBehaviour
    {
        [Range(0.1f,5f)]
        [SerializeField] float _min;
        [Range(6f, 15f)]
        [SerializeField] float _max;
        float _spawnTime;
        float _currentSpawnTime = 0f;


        private void OnEnable()
        {
            GetRandomSpawnTime();
        }
        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;
            if( _currentSpawnTime > _spawnTime)
            {
                Spawn();
            }
        }

        private void Spawn()
        {
            EnemyController newEnemy = EnemyManager.Instance.GetPool();
            newEnemy.gameObject.SetActive(true);
            newEnemy.transform.parent = this.transform;
            newEnemy.transform.position = this.transform.position;

            _currentSpawnTime = 0f;
            GetRandomSpawnTime();
        }

        void GetRandomSpawnTime()
        {
            _spawnTime = Random.Range(_min, _max);

        }
    }


}
