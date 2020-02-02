using System;
using System.Collections;
using UnityEngine;


    public class MaterialChanger : UnityEngine.MonoBehaviour
    {
        public Material[] materials;
        [SerializeField] Renderer rend;
        public int materialNmb = 0;
        public float waitTime = 1f;

        private void Start()
        {
            rend.sharedMaterial = materials[1];
        }
        public IEnumerator ButtonPressColorChange()
        {
            int i = 0;
            foreach (var VARIABLE in materials)
            {

                rend.sharedMaterial = materials[i];
                yield return new WaitForSeconds(waitTime);
                i++;
            }
            rend.sharedMaterial = materials[1];
        }

        public void ChangeMaterial()
        {
            StartCoroutine(ButtonPressColorChange());

        }
    }
