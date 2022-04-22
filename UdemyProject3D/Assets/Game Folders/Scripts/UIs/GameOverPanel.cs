using System.Collections;
using System.Collections.Generic;
using UdemyProject3D.Managers;
using UnityEngine;

namespace UdemyProject3D.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.LoadGame("CoreGame");
        }
        public void NoButton()
        {
            GameManager.Instance.LoadGame("Menu");
        }
    }

}
