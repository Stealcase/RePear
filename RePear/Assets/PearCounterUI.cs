using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PearCounterUI : MonoBehaviour
{
        public TextMeshPro pearNumberDisplay, numberAdded;
        
        public IntVariable pearNumber, numberAdder;
        

        public void UpdatePearNumber()
        {
                if(pearNumber.Value < 10)
                { 
                        pearNumberDisplay.text = "00" + pearNumber.Value.ToString();
                }

                else if (pearNumber.Value < 100)
                {
                        pearNumberDisplay.text = "0" + pearNumber.Value.ToString();
                }
                else if (pearNumber.Value < 1000)
                {
                        pearNumberDisplay.text = pearNumber.Value.ToString();
                }
                else if (pearNumber.Value < 10000)
                {
                        pearNumberDisplay.text = "0" + pearNumber.Value.ToString();
                }
                else if (pearNumber.Value >= 10000)
                {
                        pearNumberDisplay.text = "0" + pearNumber.Value.ToString();
                }
                
        }

        public void UpdateNumberAdder()
        {
                numberAdded.text = "+" + numberAdder.Value.ToString();
        }
}
