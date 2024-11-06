using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDevWithMarco.Singleton;
using GameDevWithMarco.Data;
using UnityEditor.Experimental.GraphView;

namespace GameDevWithMarco.Managers
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GlobalData globalData;

        private void Start()
        {
            if (globalData != null)
            {

                globalData.ResetsScore();
                globalData.SetTheScoreRequiredToWin();
            }
            else
            {
                Debug.LogWarning("The Global Data SO has not been assigned to the game manager");
            }
        }



        public void GameWon()
        {
            Time.timeScale = 0;

            Debug.Log("Game Won");
        }
        
    }
}
