using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UdemyProject3D.Managers;

namespace UdemyProject3D.UIs
{
    public class MenuPanel : MonoBehaviour
    {
       public void StartButton()
        {
            GameManager.Instance.LoadGame("CoreGame");
        }
        public void ExitButton()
        {
            GameManager.Instance.ExitGame();

        }
    }
}

