using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class PearSpawner : MonoBehaviour
    {
        public GameObject pearPrefab, gravPrefab;
        public IntVariable pearCounter, pearAdder;
        public GameObjectList pears;
        private List<GameObject> pearList;
        public Transform spawnPosition;
        public GameEvent pearSpawned, pearRateIncreased;
        public int i = 200;
        public float multiplierFloat =1;
        public bool multiplier= false;
        public bool isGravityOff = false;

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
            if (multiplier)
            {
                pearAdder.ApplyChange(pearAdder.Value*2);
            }

            int i = pearAdder.Value;
            i +=1;
            pearAdder.SetValue(Mathf.RoundToInt(i * multiplierFloat));
            pearRateIncreased.Raise();
            
        }
        public void SpawnPear() //This is the only function that should spawn pears. So give this thing all the attention it needs to do that efficiently
        {
            //pearList.Add(Instantiate(pearPrefab, spawnPosition));
            if (isGravityOff == true)
            {
                StartCoroutine(PearRoutine(gravPrefab));
                pearSpawned.Raise();
            }
            
            if (isGravityOff == false)
            {
                StartCoroutine(PearRoutine(pearPrefab));
                pearSpawned.Raise();
            }

  
            
          
        }

        public IEnumerator PearRoutine(GameObject gameObject)
        {
            int i = 0;
            while (i < pearAdder.Value)
            {
                pearList.Add(Instantiate(gameObject, spawnPosition));
                pearCounter.ApplyChange(+1);
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
                isGravityOff = true;
            }
        }
    }
}