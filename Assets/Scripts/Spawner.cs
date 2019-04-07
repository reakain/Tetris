﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TetrisGame
{
    public class Spawner : MonoBehaviour
    {
        // Groups
        public GameObject[] groups;

        // Start is called before the first frame update
        void Start()
        {
            // Spawn initial Group
            spawnNext();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void spawnNext()
        {
            // Random Index
            int i = Random.Range(0, groups.Length);

            // Spawn Group at current Position
            Instantiate(groups[i],
                        transform.position,
                        Quaternion.identity);
        }
    }
}