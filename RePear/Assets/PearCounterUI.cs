using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PearCounterUI : MonoBehaviour
{
        public TextMeshPro pearNumberDisplay, numberAdded;

        public IntVariable pearNumber, numberAdder;
        private int previousNum = 0;
        public GameEvent calltheTracker;



        public IEnumerator UpdateNumberSequence(int value)
        {
                while (value >= previousNum)
                {
                        if(previousNum < 10)
                        { 
                                pearNumberDisplay.text = "00" + previousNum.ToString();
                        }
                        else
                        {
                                pearNumberDisplay.text = "0" + previousNum.ToString();
                        }
                        previousNum++;
                        yield return new WaitForSeconds(0.01f);
                }

                previousNum = value;
        }
        
        public void UpdatePearNumber()
        {
                calltheTracker.Raise();
                StartCoroutine(UpdateNumberSequence(pearNumber.Value));
                
        }

        public void UpdateNumberAdder()
        {
                numberAdded.text = "+" + numberAdder.Value.ToString();
        }
}
