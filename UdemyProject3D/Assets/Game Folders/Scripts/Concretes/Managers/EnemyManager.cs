using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Abstracts.Utilities;
using UdemyProject3D.Controllers;
using System;

namespace UdemyProject3D.Managers
{
    public class EnemyManager : SingletonMonoBehaviorObject<EnemyManager>
    {
        [SerializeField] EnemyController _enemyPrefab;
        Queue<EnemyController> _enemies = new Queue<EnemyController>();

        private void Start()
        {
            InitializePool();
            SingletonThisObject(this);
        }

        private void InitializePool()
        {
            for (int i = 0; i < 10; i++)
            {
                EnemyController newEnemy = Instantiate(_enemyPrefab);
                newEnemy.gameObject.SetActive(false);
                newEnemy.transform.parent = this.transform;
                
                _enemies.Enqueue(newEnemy);
            }
        }
        public void SetPool(EnemyController enemyController)
        {
            enemyController.gameObject.SetActive(false);
            enemyController.transform.parent = this.transform;
            _enemies.Enqueue(enemyController);
        }
        public EnemyController GetPool()
        {
            if(_enemies.Count == 0)
            {
                InitializePool();
            }
            return _enemies.Dequeue();
        }
    }

}
