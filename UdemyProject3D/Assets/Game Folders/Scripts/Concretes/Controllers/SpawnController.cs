using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Enums;
using UdemyProject3D.Managers;

namespace UdemyProject3D.Controllers
{
    public class SpawnController : MonoBehaviour
    {
        [Range(0.1f,5f)]
        [SerializeField] float _min;
        [Range(6f, 15f)]
        [SerializeField] float _max;

        public bool CanIncrease => _index < EnemyManager.Instance.Count;

        float _spawnTime;
        float _currentSpawnTime = 0f;
        float maxAddEnemyTime;

        int _index = 0;


        private void OnEnable()
        {
            GetRandomSpawnTime();
        }
        private void Update()
        {
            Debug.Log(_index);
            Debug.Log(Time.time);
            _currentSpawnTime += Time.deltaTime;
            if( _currentSpawnTime > _spawnTime)
            {
                Spawn();
            }

            if (!CanIncrease) return;

            if(maxAddEnemyTime > Time.time)
            {
                maxAddEnemyTime = Time.time + EnemyManager.Instance.AddDelayTime;
                IncreaseIndex();
            }
        }

        private void IncreaseIndex()
        {
            if(CanIncrease)
            {
                _index++;
            }
        }

        private void Spawn()
        {
            EnemyController newEnemy = EnemyManager.Instance.GetPool((EnemyEnum)Random.Range(0,_index));
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
