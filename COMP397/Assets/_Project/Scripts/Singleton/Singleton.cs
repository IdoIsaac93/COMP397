using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace COMP397
{
    public abstract class Singleton<T> : MonoBehaviour where T : Component
    {
        public bool autoUnparentOnAwake = true;
        protected static T instance;
        public static bool hasInstance => instance !=null;
        public static T TryGetInstance() => hasInstance ? instance : null;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindAnyObjectByType<T>();
                    if (instance == null)
                    {
                        var go = new GameObject(typeof(T).Name + " Generated");
                        instance = go.AddComponent<T>();
                    }
                }
                return instance;
            }
        }
        protected virtual void Awake()
        {
            if(autoUnparentOnAwake)
            {
                transform.SetParent(null);
            }
            if(instance == null)
            {
                instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                if (instance != this)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
