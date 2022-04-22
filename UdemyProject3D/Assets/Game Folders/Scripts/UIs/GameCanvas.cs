using UnityEngine;
using UdemyProject3D.Managers;
using System;

namespace UdemyProject3D.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameoverPanel;

        private void Awake()
        {
            _gameoverPanel.gameObject.SetActive(false);
        }

        void OnEnable()
        {
            GameManager.Instance.OnGameStop += GameStopHandle;

        }
        void OnDisable()
        {
            GameManager.Instance.OnGameStop -= GameStopHandle;

        }
        private void GameStopHandle()
        {
            _gameoverPanel.gameObject.SetActive(true);
        }

        
    }
}
