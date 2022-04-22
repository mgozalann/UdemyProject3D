using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UdemyProject3D.Abstracts.Utilities;

namespace UdemyProject3D.Managers
{
    public class GameManager : SingletonMonoBehaviorObject<GameManager>
    {

        public event System.Action OnGameStop;
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

