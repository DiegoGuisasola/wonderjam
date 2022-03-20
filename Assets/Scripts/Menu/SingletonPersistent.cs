using UnityEngine;

namespace Menu
{
    public class SingletonPersistent<T> : MonoBehaviour where T : Component
    {
        private static T _instance; // Added
        public static T Instance;
    
        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
                transform.parent = null;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(gameObject);
            }

            Instance = _instance;
        }
    }
}