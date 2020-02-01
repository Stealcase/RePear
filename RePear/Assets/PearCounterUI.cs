using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PearCounterUI : MonoBehaviour
{
        public TextMeshProUGUI pearNumberDisplay, numberAdded;
        
        public IntVariable pearNumber;
        

        public void UpdatePearNumber()
        {
                pearNumberDisplay.text = pearNumber.Value.ToString();
        }
        
}
