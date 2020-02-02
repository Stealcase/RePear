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
        public GameObjectList pears;
        private List<GameObject> pearList;
        public Transform spawnPosition;
        public GameEvent pearSpawned;
        public int i = 200;
        public int pearsPerPress =1;

        public void Start()
        {
            pearList = new List<GameObject>();
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

        public void IncreasePearsPerPress()
        {
            pearsPerPress++;
        }
        public void SpawnPear() //This is the only function that should spawn pears. So give this thing all the attention it needs to do that efficiently
        {
            //pearList.Add(Instantiate(pearPrefab, spawnPosition));
            
            StartCoroutine(PearRoutine());
          
        }

        public IEnumerator PearRoutine()
        {
            int i = 0;
            while (i < pearsPerPress)
            {
                pearList.Add(Instantiate(pearPrefab, spawnPosition));
                pearCounter.ApplyChange(+1);
                pearSpawned.Raise();
                yield return new WaitForSeconds(0.01f);
                i++;
            }
        }

        public void DisableGravity()
        {
            foreach (GameObject p in pearList)
            {
                Rigidbody rb = p.GetComponent<Rigidbody>();
                rb.useGravity = false;
            }
        }
    }
}