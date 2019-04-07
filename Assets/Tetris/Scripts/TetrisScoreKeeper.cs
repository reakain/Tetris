using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TetrisGame
{
    public class TetrisScoreKeeper : MonoBehaviour
    {
        public Text scoreText;
        int Score = 0;

        public void IncreaseScore()
        {
            Score += 10;
            scoreText.text = Score.ToString();
        }

        public void GameOver()
        {
            FindObjectOfType<TetrisGameController>().GameOver(Score);
        }
    }
}