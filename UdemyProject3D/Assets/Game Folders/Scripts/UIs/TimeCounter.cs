using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UdemyProject3D.UIs
{
    public class TimeCounter : MonoBehaviour
    {
        Text _timerText;
        float currentTime = 0f;
        void Start()
        {
            _timerText = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            _timerText.text = currentTime.ToString("0");
        }


    }

}
