﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TetrisGame
{
    public class StartScreen : MonoBehaviour
    {
        public Text highScore;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                this.GetComponentInParent<TetrisGameController>().InstantiateGame();
            }
        }

        public void SetHighScore(int score)
        {
            highScore.text = score.ToString();
        }
    }
}