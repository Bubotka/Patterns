using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;

        private void Start()
        {
            _sessionStartTime = DateTime.Now;
            Debug.Log(_sessionStartTime);
        }

        private void OnApplicationQuit()
        {
            _sessionEndTime = DateTime.Now;
            Debug.Log(_sessionEndTime);
        }

        private void OnGUI()
        {
            if (GUILayout.Button("NextScene")) 
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
