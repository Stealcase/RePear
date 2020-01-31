using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PearCounterUI : MonoBehaviour
{
        private TextMeshProUGUI textDisplay;
        public IntVariable pearNumber;

        private void Start()
        {
                textDisplay = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void UpdatePearNumber()
        {
                textDisplay.text = pearNumber.Value.ToString();
        }
        
}
