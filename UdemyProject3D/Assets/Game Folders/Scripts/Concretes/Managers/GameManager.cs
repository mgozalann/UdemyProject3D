using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject3D.Abstracts.Utilities;
using UdemyProject3D.ScriptableObjects;

namespace UdemyProject3D.Managers
{
    public class GameManager : SingletonMonoBehaviorObject<GameManager>
    {
        [SerializeField] LevelDifficultyData[] _levelDifficultyData;

        public event System.Action OnGameStop;

        public LevelDifficultyData LevelDifficultyData => _levelDifficultyData[2];

        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0;
            OnGameStop?.Invoke();
        }

        public void LoadGame(string sceneName)
        {
            StartCoroutine(LoadSceneAsync(sceneName));
        }

        IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }

}

