using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class PearSpawner : MonoBehaviour
    {
        public GameObject pearPrefab;
        public IntVariable pearCounter;
        private List<GameObject> pears;
        public Transform spawnPosition;
        public GameEvent pearSpawned;
        public int i = 200;

        public void Start()
        {
            pears = new List<GameObject>();
            StartCoroutine("NumberedSpawner", 0.1f);
        }

        public IEnumerator NumberedSpawner()
        {
            int k = 0;
            while (k < i)
            {
                SpawnPear();
                yield return new WaitForSeconds(0.01f);
                print("pear spawned");
                k++;
            }
            
        }
        public void SpawnPear() //This is the only function that should spawn pears. So give this thing all the attention it needs to do that efficiently
        {
            pears.Add(Instantiate(pearPrefab, spawnPosition));
            pearCounter.ApplyChange(+1);
            pearSpawned.Raise();
        }

        public void DisableGravity()
        {
            foreach (GameObject p in pears)
            {
                Rigidbody rb = p.GetComponent<Rigidbody>();
                rb.useGravity = false;
            }
        }
    }
}