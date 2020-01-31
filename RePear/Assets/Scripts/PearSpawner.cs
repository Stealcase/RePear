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

        public void Start()
        {
            pears = new List<GameObject>();
            StartCoroutine("NumberedSpawner", 0.1f);
        }

        public IEnumerator NumberedSpawner()
        {
            int i = 2000;
            int k = 0;
            while (k < i)
            {
                SpawnPear();
                yield return new WaitForSeconds(0.1f);
                print("pear spawned");
                k++;
            }
            
        }
        public void SpawnPear()
        {
            pears.Add(Instantiate(pearPrefab, spawnPosition));
            pearCounter.ApplyChange(+1);
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