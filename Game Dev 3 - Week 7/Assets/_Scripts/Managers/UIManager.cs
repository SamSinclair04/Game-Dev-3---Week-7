using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameDevWithMarco.Managers;
using GameDevWithMarco.Data;

namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoretext;
        [SerializeField] GlobalData globalData;



        public void UpdateScoreText()
        {
            if (globalData != null)
            {


                scoretext.text = $"<b>Score</b>:{globalData.Score}";
            }
            else
            {
                Debug.Log("No Global Data SO assigned to the UIManager.");
            }
        }
    }
}
