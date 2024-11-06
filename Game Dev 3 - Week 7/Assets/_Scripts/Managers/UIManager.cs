using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameDevWithMarco.Managers;

namespace GameDevWithMarco.Managers
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] TMP_Text scoretext;

        public void UpdateScoreText()
        {
            scoretext.text = $"<b>Score</b>:{GameManager.Instance.Score}";
        }
    }
}
