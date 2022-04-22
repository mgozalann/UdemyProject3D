using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject3D.Abstracts.Utilities
{
    public abstract class SingletonMonoBehaviorObject<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }    

        public void SingletonThisObject(T entity)
        {
            if(Instance == null)
            {
                Instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
